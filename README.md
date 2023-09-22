# Unifi Restart Script

This is a simple script written in C# that reads a list of IP addresses from a text file and restarts UniFi devices over SSH.

## How it Works

1. The script reads a list of IP addresses from a specified text file.
2. It iterates through each IP address in the list.
3. For each IP address, it establishes an SSH connection using the provided username and password.
4. It sends a `reboot` command over SSH to restart the UniFi device.

## Requirements

- [.NET Core](https://dotnet.microsoft.com/download/dotnet) (to compile and run the script)
- [Renci.SshNet](https://github.com/sshnet/SSH.NET) library for SSH connectivity

## Usage

1. Clone this repository or download the source code.
2. Build the project using `dotnet build`.
3. Create a text file containing a list of IP addresses, one per line, and specify the file path in the `filePath` variable in the `Main` method.
4. Replace the `username` and `password` variables with your SSH login credentials.
5. Run the compiled executable or use `dotnet run` to execute the script.

## Example

```csharp
string filePath = "path/to/your/ip_addresses.txt";
string username = "Your Unifi SSHUsername";
string password = "Your Unifi SSHPassword";
