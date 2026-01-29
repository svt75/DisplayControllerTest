namespace DisplayControllerTest;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        // Form
        this.SuspendLayout();
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        this.ClientSize = new System.Drawing.Size(684, 711);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Display Controller Test";

        // Title
        lblTitle = new Label();
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(255, 68, 68);
        lblTitle.Location = new Point(200, 15);
        lblTitle.Text = "DISPLAY CONTROLLER TEST";
        this.Controls.Add(lblTitle);

        // Connection Panel
        pnlConnection = new Panel();
        pnlConnection.BackColor = Color.FromArgb(45, 45, 45);
        pnlConnection.Location = new Point(12, 50);
        pnlConnection.Size = new Size(660, 45);
        this.Controls.Add(pnlConnection);

        // IP
        var lblIP = new Label { Text = "IP:", ForeColor = Color.White, Location = new Point(10, 13), AutoSize = true };
        pnlConnection.Controls.Add(lblIP);
        txtIP = new TextBox { Text = "192.168.1.151", Location = new Point(35, 10), Size = new Size(120, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        pnlConnection.Controls.Add(txtIP);

        // Port
        var lblPort = new Label { Text = "Port:", ForeColor = Color.White, Location = new Point(165, 13), AutoSize = true };
        pnlConnection.Controls.Add(lblPort);
        txtPort = new TextBox { Text = "9854", Location = new Point(200, 10), Size = new Size(50, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        pnlConnection.Controls.Add(txtPort);

        // Token
        var lblToken = new Label { Text = "Token:", ForeColor = Color.White, Location = new Point(260, 13), AutoSize = true };
        pnlConnection.Controls.Add(lblToken);
        txtToken = new TextBox { Text = "A1545fe1ew484897we31efKL9", Location = new Point(305, 10), Size = new Size(200, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        pnlConnection.Controls.Add(txtToken);

        // Test Button
        btnTest = new Button { Text = "Test", Location = new Point(515, 8), Size = new Size(60, 28), BackColor = Color.FromArgb(68, 136, 255), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnTest.Click += btnTest_Click;
        pnlConnection.Controls.Add(btnTest);

        // Status
        lblStatus = new Label { Text = "●", ForeColor = Color.Gray, Location = new Point(585, 12), AutoSize = true, Font = new Font("Arial", 14F) };
        pnlConnection.Controls.Add(lblStatus);

        // Screen 1 GroupBox
        grpScreen1 = new GroupBox();
        grpScreen1.Text = " SCREEN 1 (576×384) ";
        grpScreen1.ForeColor = Color.FromArgb(255, 100, 100);
        grpScreen1.Font = new Font("Arial", 10F, FontStyle.Bold);
        grpScreen1.Location = new Point(12, 105);
        grpScreen1.Size = new Size(325, 255);
        this.Controls.Add(grpScreen1);

        CreateScreen1Controls();

        // Screen 2 GroupBox
        grpScreen2 = new GroupBox();
        grpScreen2.Text = " SCREEN 2 (288×192) ";
        grpScreen2.ForeColor = Color.FromArgb(100, 255, 100);
        grpScreen2.Font = new Font("Arial", 10F, FontStyle.Bold);
        grpScreen2.Location = new Point(347, 105);
        grpScreen2.Size = new Size(325, 255);
        this.Controls.Add(grpScreen2);

        CreateScreen2Controls();

        // Global Buttons Panel
        pnlGlobal = new Panel();
        pnlGlobal.BackColor = Color.FromArgb(45, 45, 45);
        pnlGlobal.Location = new Point(12, 370);
        pnlGlobal.Size = new Size(660, 90);
        this.Controls.Add(pnlGlobal);

        btnSendBoth = new Button { Text = "SEND BOTH", Location = new Point(100, 10), Size = new Size(110, 30), BackColor = Color.FromArgb(68, 170, 68), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Arial", 10F, FontStyle.Bold) };
        btnSendBoth.Click += btnSendBoth_Click;
        pnlGlobal.Controls.Add(btnSendBoth);

        btnClearAll = new Button { Text = "CLEAR ALL", Location = new Point(220, 10), Size = new Size(100, 30), BackColor = Color.FromArgb(170, 68, 68), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnClearAll.Click += btnClearAll_Click;
        pnlGlobal.Controls.Add(btnClearAll);

        btnClockOn = new Button { Text = "CLOCK ON", Location = new Point(340, 10), Size = new Size(90, 30), BackColor = Color.FromArgb(68, 68, 170), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnClockOn.Click += btnClockOn_Click;
        pnlGlobal.Controls.Add(btnClockOn);

        btnClockOff = new Button { Text = "CLOCK OFF", Location = new Point(440, 10), Size = new Size(90, 30), BackColor = Color.FromArgb(80, 80, 80), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnClockOff.Click += btnClockOff_Click;
        pnlGlobal.Controls.Add(btnClockOff);

        btnBorderOn = new Button { Text = "BORDER ON", Location = new Point(220, 50), Size = new Size(100, 30), BackColor = Color.FromArgb(170, 100, 68), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnBorderOn.Click += btnBorderOn_Click;
        pnlGlobal.Controls.Add(btnBorderOn);

        btnBorderOff = new Button { Text = "BORDER OFF", Location = new Point(330, 50), Size = new Size(100, 30), BackColor = Color.FromArgb(80, 80, 80), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnBorderOff.Click += btnBorderOff_Click;
        pnlGlobal.Controls.Add(btnBorderOff);

        // Log
        var lblLog = new Label { Text = "Log:", ForeColor = Color.Gray, Location = new Point(12, 470), AutoSize = true };
        this.Controls.Add(lblLog);

        txtLog = new TextBox();
        txtLog.Location = new Point(12, 490);
        txtLog.Size = new Size(660, 250);
        txtLog.Multiline = true;
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.BackColor = Color.Black;
        txtLog.ForeColor = Color.Lime;
        txtLog.Font = new Font("Consolas", 9F);
        txtLog.ReadOnly = true;
        this.Controls.Add(txtLog);

        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private void CreateScreen1Controls()
    {
        var normalFont = new Font("Arial", 9F);
        int y = 25;

        // Line 1
        grpScreen1.Controls.Add(new Label { Text = "Line 1:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine1_1 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(txtLine1_1);
        numFont1_1 = new NumericUpDown { Value = 24, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(numFont1_1);

        // Line 2
        y += 32;
        grpScreen1.Controls.Add(new Label { Text = "Line 2:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine1_2 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(txtLine1_2);
        numFont1_2 = new NumericUpDown { Value = 24, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(numFont1_2);

        // Line 3
        y += 32;
        grpScreen1.Controls.Add(new Label { Text = "Line 3:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine1_3 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(txtLine1_3);
        numFont1_3 = new NumericUpDown { Value = 24, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(numFont1_3);

        // Line 4
        y += 32;
        grpScreen1.Controls.Add(new Label { Text = "Line 4:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine1_4 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(txtLine1_4);
        numFont1_4 = new NumericUpDown { Value = 24, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(numFont1_4);

        // Line 5
        y += 32;
        grpScreen1.Controls.Add(new Label { Text = "Line 5:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine1_5 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(txtLine1_5);
        numFont1_5 = new NumericUpDown { Value = 24, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(numFont1_5);

        // Line 6
        y += 32;
        grpScreen1.Controls.Add(new Label { Text = "Line 6:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine1_6 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(txtLine1_6);
        numFont1_6 = new NumericUpDown { Value = 24, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen1.Controls.Add(numFont1_6);

        // Buttons
        y += 35;
        btnSend1 = new Button { Text = "SEND", Location = new Point(60, y), Size = new Size(70, 28), BackColor = Color.FromArgb(68, 170, 68), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnSend1.Click += btnSend1_Click;
        grpScreen1.Controls.Add(btnSend1);

        btnClear1 = new Button { Text = "Clear", Location = new Point(140, y), Size = new Size(60, 28), BackColor = Color.FromArgb(80, 80, 80), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnClear1.Click += btnClear1_Click;
        grpScreen1.Controls.Add(btnClear1);

        btnFill1 = new Button { Text = "Fill", Location = new Point(210, y), Size = new Size(50, 28), BackColor = Color.FromArgb(80, 80, 80), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnFill1.Click += btnFill1_Click;
        grpScreen1.Controls.Add(btnFill1);
    }

    private void CreateScreen2Controls()
    {
        var normalFont = new Font("Arial", 9F);
        int y = 25;

        // Line 1
        grpScreen2.Controls.Add(new Label { Text = "Line 1:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine2_1 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(txtLine2_1);
        numFont2_1 = new NumericUpDown { Value = 18, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(numFont2_1);

        // Line 2
        y += 32;
        grpScreen2.Controls.Add(new Label { Text = "Line 2:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine2_2 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(txtLine2_2);
        numFont2_2 = new NumericUpDown { Value = 18, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(numFont2_2);

        // Line 3
        y += 32;
        grpScreen2.Controls.Add(new Label { Text = "Line 3:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine2_3 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(txtLine2_3);
        numFont2_3 = new NumericUpDown { Value = 18, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(numFont2_3);

        // Line 4
        y += 32;
        grpScreen2.Controls.Add(new Label { Text = "Line 4:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine2_4 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(txtLine2_4);
        numFont2_4 = new NumericUpDown { Value = 18, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(numFont2_4);

        // Line 5
        y += 32;
        grpScreen2.Controls.Add(new Label { Text = "Line 5:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine2_5 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(txtLine2_5);
        numFont2_5 = new NumericUpDown { Value = 18, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(numFont2_5);

        // Line 6
        y += 32;
        grpScreen2.Controls.Add(new Label { Text = "Line 6:", ForeColor = Color.White, Font = normalFont, Location = new Point(10, y + 3), AutoSize = true });
        txtLine2_6 = new TextBox { Location = new Point(60, y), Size = new Size(180, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(txtLine2_6);
        numFont2_6 = new NumericUpDown { Value = 18, Minimum = 8, Maximum = 72, Location = new Point(250, y), Size = new Size(55, 23), BackColor = Color.FromArgb(50, 50, 50), ForeColor = Color.White };
        grpScreen2.Controls.Add(numFont2_6);

        // Buttons
        y += 35;
        btnSend2 = new Button { Text = "SEND", Location = new Point(60, y), Size = new Size(70, 28), BackColor = Color.FromArgb(68, 170, 68), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnSend2.Click += btnSend2_Click;
        grpScreen2.Controls.Add(btnSend2);

        btnClear2 = new Button { Text = "Clear", Location = new Point(140, y), Size = new Size(60, 28), BackColor = Color.FromArgb(80, 80, 80), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnClear2.Click += btnClear2_Click;
        grpScreen2.Controls.Add(btnClear2);

        btnFill2 = new Button { Text = "Fill", Location = new Point(210, y), Size = new Size(50, 28), BackColor = Color.FromArgb(80, 80, 80), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        btnFill2.Click += btnFill2_Click;
        grpScreen2.Controls.Add(btnFill2);
    }

    #endregion

    private Label lblTitle;
    private Panel pnlConnection;
    private TextBox txtIP;
    private TextBox txtPort;
    private TextBox txtToken;
    private Button btnTest;
    private Label lblStatus;

    private GroupBox grpScreen1;
    private TextBox txtLine1_1, txtLine1_2, txtLine1_3, txtLine1_4, txtLine1_5, txtLine1_6;
    private NumericUpDown numFont1_1, numFont1_2, numFont1_3, numFont1_4, numFont1_5, numFont1_6;
    private Button btnSend1, btnClear1, btnFill1;

    private GroupBox grpScreen2;
    private TextBox txtLine2_1, txtLine2_2, txtLine2_3, txtLine2_4, txtLine2_5, txtLine2_6;
    private NumericUpDown numFont2_1, numFont2_2, numFont2_3, numFont2_4, numFont2_5, numFont2_6;
    private Button btnSend2, btnClear2, btnFill2;

    private Panel pnlGlobal;
    private Button btnSendBoth, btnClearAll, btnClockOn, btnClockOff, btnBorderOn, btnBorderOff;

    private TextBox txtLog;
}
