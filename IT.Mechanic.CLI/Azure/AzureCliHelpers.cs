using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

// TODO: Make Work
public static class AzureCliHelpers
{
    // Method to install Azure CLI globally using winget on Windows
    public static void InstallAzureCli()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // Define the command to install Azure CLI using winget
            string command = "winget install --id Microsoft.AzureCLI --source winget";

            try
            {
                // Execute the command
                RunCommand(command);
                Console.WriteLine("Azure CLI installation initiated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while installing Azure CLI: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("This installation method is only supported on Windows.");
        }
    }

    // Method to check if Azure CLI is installed
    public static bool IsAzureCliInstalled()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            string command = "az --version";
            try
            {
                var output = RunCommand(command, captureOutput: true);
                if (output.Contains("azure-cli"))
                {
                    Console.WriteLine("Azure CLI is installed.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Azure CLI is not installed.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"An error occurred while checking Azure CLI installation: {ex.Message}"
                );
                return false;
            }
        }
        else
        {
            Console.WriteLine("This check is only supported on Windows.");
            return false;
        }
    }

    // Helper method to run a shell command
    private static string RunCommand(string command, bool captureOutput = false)
    {
        var processStartInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = $"/c {command}",
            RedirectStandardOutput = captureOutput,
            RedirectStandardError = captureOutput,
            UseShellExecute = !captureOutput,
            CreateNoWindow = true,
        };

        using (var process = Process.Start(processStartInfo))
        {
            if (process == null)
                throw new InvalidOperationException("Failed to start process.");

            // Read the command output
            string output = captureOutput ? process.StandardOutput.ReadToEnd() : string.Empty;
            string error = captureOutput ? process.StandardError.ReadToEnd() : string.Empty;
            process.WaitForExit();

            Console.WriteLine(output);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine("Error: " + error);
            }

            return output;
        }
    }
}
