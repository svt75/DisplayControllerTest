using System.Net.Http;
using System.Text;

namespace DisplayControllerTest;

public partial class MainForm : Form
{
    private static readonly HttpClient client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

    public MainForm()
    {
        InitializeComponent();
    }

    private void Log(string msg)
    {
        if (txtLog.InvokeRequired)
        {
            txtLog.Invoke(() => Log(msg));
            return;
        }
        txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\r\n");
    }

    private string GetBaseUrl() => $"http://{txtIP.Text}:{txtPort.Text}";

    private async Task<bool> SendRequest(string method, string endpoint, string json = null)
    {
        try
        {
            var url = GetBaseUrl() + endpoint;
            var request = new HttpRequestMessage(
                method == "GET" ? HttpMethod.Get : HttpMethod.Post, url);
            request.Headers.Add("Authorization", $"Bearer {txtToken.Text}");

            if (json != null)
            {
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            var response = await client.SendAsync(request);
            var result = await response.Content.ReadAsStringAsync();
            Log($"{endpoint}: {result}");
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Log($"Error: {ex.Message}");
            return false;
        }
    }

    private async void btnTest_Click(object sender, EventArgs e)
    {
        Log("Testing connection...");
        var ok = await SendRequest("GET", "/status");
        lblStatus.Text = ok ? "●" : "●";
        lblStatus.ForeColor = ok ? Color.Lime : Color.Red;
    }

    private async void btnSend1_Click(object sender, EventArgs e)
    {
        await SendScreenData(1, new[] { txtLine1_1, txtLine1_2, txtLine1_3, txtLine1_4, txtLine1_5, txtLine1_6 },
            new[] { numFont1_1, numFont1_2, numFont1_3, numFont1_4, numFont1_5, numFont1_6 });
    }

    private async void btnSend2_Click(object sender, EventArgs e)
    {
        await SendScreenData(2, new[] { txtLine2_1, txtLine2_2, txtLine2_3, txtLine2_4, txtLine2_5, txtLine2_6 },
            new[] { numFont2_1, numFont2_2, numFont2_3, numFont2_4, numFont2_5, numFont2_6 });
    }

    private async Task SendScreenData(int screen, TextBox[] lines, NumericUpDown[] fonts)
    {
        var sb = new StringBuilder("{");
        var hasData = false;

        for (int i = 0; i < 6; i++)
        {
            var text = lines[i].Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                if (hasData) sb.Append(",");
                var escaped = text.Replace("\\", "\\\\").Replace("\"", "\\\"");
                sb.Append($"\"line{i + 1}\":{{\"text\":\"{escaped}\",\"fontSize\":{fonts[i].Value}}}");
                hasData = true;
            }
        }
        sb.Append("}");

        if (!hasData)
        {
            Log($"Screen {screen}: No data");
            return;
        }

        Log($"Sending to screen {screen}...");
        await SendRequest("POST", $"/set{screen}", sb.ToString());
    }

    private async void btnClear1_Click(object sender, EventArgs e)
    {
        Log("Clearing screen 1...");
        await SendRequest("POST", "/clear1");
        txtLine1_1.Text = txtLine1_2.Text = txtLine1_3.Text = txtLine1_4.Text = txtLine1_5.Text = txtLine1_6.Text = "";
    }

    private async void btnClear2_Click(object sender, EventArgs e)
    {
        Log("Clearing screen 2...");
        await SendRequest("POST", "/clear2");
        txtLine2_1.Text = txtLine2_2.Text = txtLine2_3.Text = txtLine2_4.Text = txtLine2_5.Text = txtLine2_6.Text = "";
    }

    private void btnFill1_Click(object sender, EventArgs e)
    {
        txtLine1_1.Text = "Тест строка 1";
        txtLine1_2.Text = "Тест строка 2";
        txtLine1_3.Text = "Тест строка 3";
        txtLine1_4.Text = "Тест строка 4";
        txtLine1_5.Text = "Тест строка 5";
        txtLine1_6.Text = "Тест строка 6";
        Log("Screen 1: Filled");
    }

    private void btnFill2_Click(object sender, EventArgs e)
    {
        txtLine2_1.Text = "Test line 1";
        txtLine2_2.Text = "Test line 2";
        txtLine2_3.Text = "Test line 3";
        txtLine2_4.Text = "Test line 4";
        txtLine2_5.Text = "Test line 5";
        txtLine2_6.Text = "Test line 6";
        Log("Screen 2: Filled");
    }

    private async void btnSendBoth_Click(object sender, EventArgs e)
    {
        btnSend1_Click(sender, e);
        await Task.Delay(200);
        btnSend2_Click(sender, e);
    }

    private async void btnClearAll_Click(object sender, EventArgs e)
    {
        Log("Clearing all...");
        await SendRequest("POST", "/clear");
        txtLine1_1.Text = txtLine1_2.Text = txtLine1_3.Text = txtLine1_4.Text = txtLine1_5.Text = txtLine1_6.Text = "";
        txtLine2_1.Text = txtLine2_2.Text = txtLine2_3.Text = txtLine2_4.Text = txtLine2_5.Text = txtLine2_6.Text = "";
    }

    private async void btnClockOn_Click(object sender, EventArgs e)
    {
        Log("Starting clock...");
        await SendRequest("POST", "/clock");
    }

    private async void btnClockOff_Click(object sender, EventArgs e)

    private async void btnBorderOn_Click(object sender, EventArgs e)
    {
        Log("Border ON...");
        await SendRequest("POST", "/border");
    }

    private async void btnBorderOff_Click(object sender, EventArgs e)
    {
        Log("Border OFF...");
        await SendRequest("POST", "/border/off");
    }
    {
        Log("Stopping clock...");
        await SendRequest("POST", "/clock/stop");
    }
}
