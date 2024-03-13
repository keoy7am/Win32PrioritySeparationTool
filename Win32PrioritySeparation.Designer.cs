namespace Win32PrioritySeparationTool
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.led_DisplayCurrentValue = new Sunny.UI.UILedDisplay();
            this.lb_CurrentValue = new Sunny.UI.UILedLabel();
            this.cbg_options = new Sunny.UI.UICheckBoxGroup();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.SuspendLayout();
            // 
            // led_DisplayCurrentValue
            // 
            this.led_DisplayCurrentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.led_DisplayCurrentValue.BackColor = System.Drawing.Color.Black;
            this.led_DisplayCurrentValue.CharCount = 3;
            this.led_DisplayCurrentValue.ForeColor = System.Drawing.Color.Lime;
            this.led_DisplayCurrentValue.Location = new System.Drawing.Point(515, 47);
            this.led_DisplayCurrentValue.Name = "led_DisplayCurrentValue";
            this.led_DisplayCurrentValue.Size = new System.Drawing.Size(64, 34);
            this.led_DisplayCurrentValue.TabIndex = 0;
            this.led_DisplayCurrentValue.Text = "Nan";
            // 
            // lb_CurrentValue
            // 
            this.lb_CurrentValue.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_CurrentValue.Location = new System.Drawing.Point(4, 47);
            this.lb_CurrentValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_CurrentValue.Name = "lb_CurrentValue";
            this.lb_CurrentValue.Size = new System.Drawing.Size(216, 34);
            this.lb_CurrentValue.TabIndex = 1;
            this.lb_CurrentValue.Text = "CurrentValue";
            // 
            // cbg_options
            // 
            this.cbg_options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbg_options.ColumnCount = 7;
            this.cbg_options.ColumnInterval = 1;
            this.cbg_options.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbg_options.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.cbg_options.Items.AddRange(new object[] {
            "2",
            "20",
            "21",
            "22",
            "24",
            "25",
            "26",
            "36",
            "37",
            "38",
            "40",
            "41",
            "42"});
            this.cbg_options.ItemSize = new System.Drawing.Size(80, 40);
            this.cbg_options.Location = new System.Drawing.Point(4, 89);
            this.cbg_options.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbg_options.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbg_options.Name = "cbg_options";
            this.cbg_options.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.cbg_options.RowInterval = 1;
            this.cbg_options.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("cbg_options.SelectedIndexes")));
            this.cbg_options.Size = new System.Drawing.Size(575, 114);
            this.cbg_options.TabIndex = 2;
            this.cbg_options.Text = "Switch Options";
            this.cbg_options.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbg_options.TitleTop = 8;
            this.cbg_options.ValueChanged += new Sunny.UI.UICheckBoxGroup.OnValueChanged(this.cbg_options_ValueChanged);
            this.cbg_options.Load += new System.EventHandler(this.cbg_options_Load);
            // 
            // StyleManager
            // 
            this.StyleManager.DPIScale = true;
            this.StyleManager.GlobalFont = true;
            this.StyleManager.GlobalFontName = "Arial Black";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(583, 208);
            this.Controls.Add(this.cbg_options);
            this.Controls.Add(this.lb_CurrentValue);
            this.Controls.Add(this.led_DisplayCurrentValue);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Win32PrioritySeparation";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 595, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILedDisplay led_DisplayCurrentValue;
        private Sunny.UI.UILedLabel lb_CurrentValue;
        private Sunny.UI.UICheckBoxGroup cbg_options;
        private Sunny.UI.UIStyleManager StyleManager;
    }
}

