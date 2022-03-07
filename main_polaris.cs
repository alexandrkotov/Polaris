using Renci.SshNet;

SshClient cSSH = new SshClient("192.168.8.136", 22, "user", "1");
cSSH.Connect();
SshCommand x = cSSH.RunCommand("mkdir polaris_showcase");
ScpClient client = new ScpClient("192.168.8.136", "user", "1");
client.Connect();
client.Upload(new FileInfo("D:\\showcase\\remote_script.py"), "/home/user/polaris_showcase_cs/remote_script.py");

SshCommand y = cSSH.RunCommand("python3 /home/user/polaris_showcase_cs/remote_script.py");
Thread.Sleep(1000);
client.Download("/home/user/polaris_showcase_cs/report.json", new FileInfo("D:\\showcase\\report.json"));

client.Disconnect();
client.Dispose();
cSSH.Disconnect();
cSSH.Dispose();
