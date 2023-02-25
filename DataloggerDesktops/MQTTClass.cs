using MQTTnet.Client;
using MQTTnet.Protocol;
using MQTTnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTChanel
{
  public partial class MQTTClass : MetroFramework.Forms.MetroForm
  {
    // MQTT Setting 
    private IMqttClient client;
    private MqttClientOptions clientOptions;
    public delegate void _ShowMessageRT(string msg, string s);

    string BrokerAddress = "ismaillowkey.my.id";
    int BrokerPort = 1883;

    string output;

    // MQTT
    public async void Connect()
    {
      // use a unique id as client id, each time we start the application
      var clientId = Guid.NewGuid().ToString();

      var factory = new MqttFactory();
      client = factory.CreateMqttClient();
      clientOptions = new MqttClientOptionsBuilder()
          .WithTcpServer(BrokerAddress, BrokerPort) // Port is optional
          .WithClientId(clientId)
          .Build();

      client.ConnectedAsync += Client_ConnectedAsync;
      client.ConnectingAsync += Client_ConnectingAsync;
      client.DisconnectedAsync += Client_DisconnectedAsync;
      client.ApplicationMessageReceivedAsync += Client_ApplicationMessageReceivedAsync;

      await client.ConnectAsync(clientOptions, CancellationToken.None);

      //subcribe();
      MessageBox.Show("Connect Sucsess");
    }
    private Task Client_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
    {
      // get payload
      string ReceivedMessage = Encoding.UTF8.GetString(arg.ApplicationMessage.Payload);

      // get topic name
      string TopicReceived = arg.ApplicationMessage.Topic;

      // Show message
      ShowMessageRT(ReceivedMessage, TopicReceived);

      return Task.CompletedTask;
    }

    // Disconnect
    private async Task Client_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
    {
      await Task.Delay(TimeSpan.FromSeconds(3));
      await client.ConnectAsync(clientOptions, CancellationToken.None);
      await Task.CompletedTask;
    }

    // Connecting
    private async Task Client_ConnectingAsync(MqttClientConnectingEventArgs arg)
    {
      await Task.CompletedTask;
    }

    // Connected
    private async Task Client_ConnectedAsync(MqttClientConnectedEventArgs arg)
    {
      await Task.CompletedTask;
    }

    public void ShowMessageRT(String msg, String s)
    {
      if (InvokeRequired)
      {
        Invoke(new _ShowMessageRT(ShowMessageRT), new Object[] { msg, s });
        return;
      }
      output = msg;
    }

    public async void publish(string topic, string payload)
    {
      try
      {
        var message = new MqttApplicationMessageBuilder()
            .WithTopic(topic.Trim())
            .WithPayload(payload)
            .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
            .WithRetainFlag()
            .Build();
        await client.PublishAsync(message, CancellationToken.None);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    public async void subcribe(string topic)
    {
      try
      {
        var topic_sub = new MqttTopicFilterBuilder()
            .WithTopic(topic)
            .WithAtMostOnceQoS()
            .Build();

        await client.SubscribeAsync(topic_sub);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }


    public string payloadResult()
    {
      return output;
    }
  }
}