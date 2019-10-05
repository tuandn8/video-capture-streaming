namespace VideoStreaming
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoginYoutube = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYoutubeUrl = new System.Windows.Forms.TextBox();
            this.txtYoutubeKey = new System.Windows.Forms.TextBox();
            this.btnStopStreamYoutube = new System.Windows.Forms.Button();
            this.btnStreamYoutube = new System.Windows.Forms.Button();
            this.Twitch = new System.Windows.Forms.GroupBox();
            this.txtTwitchUrl = new System.Windows.Forms.TextBox();
            this.txtTwitchKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSteamUrl = new System.Windows.Forms.TextBox();
            this.txtSteamKey = new System.Windows.Forms.TextBox();
            this.btnStopSteam = new System.Windows.Forms.Button();
            this.btnStartSteam = new System.Windows.Forms.Button();
            this.btnStopMixer = new System.Windows.Forms.Button();
            this.btnStartMixer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMixerUrl = new System.Windows.Forms.TextBox();
            this.txtMixerKey = new System.Windows.Forms.TextBox();
            this.btnStopWowza = new System.Windows.Forms.Button();
            this.btnStartWowza = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWowzaUrl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Twitch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Stream";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Form1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(826, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 27);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Stream";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoginYoutube
            // 
            this.btnLoginYoutube.Location = new System.Drawing.Point(21, 19);
            this.btnLoginYoutube.Name = "btnLoginYoutube";
            this.btnLoginYoutube.Size = new System.Drawing.Size(99, 29);
            this.btnLoginYoutube.TabIndex = 2;
            this.btnLoginYoutube.Text = "Login to Youtube";
            this.btnLoginYoutube.UseVisualStyleBackColor = true;
            this.btnLoginYoutube.Click += new System.EventHandler(this.btnLoginYoutube_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYoutubeUrl);
            this.groupBox1.Controls.Add(this.txtYoutubeKey);
            this.groupBox1.Controls.Add(this.btnStopStreamYoutube);
            this.groupBox1.Controls.Add(this.btnStreamYoutube);
            this.groupBox1.Controls.Add(this.btnLoginYoutube);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Youtube";
            // 
            // txtYoutubeUrl
            // 
            this.txtYoutubeUrl.Location = new System.Drawing.Point(126, 19);
            this.txtYoutubeUrl.Multiline = true;
            this.txtYoutubeUrl.Name = "txtYoutubeUrl";
            this.txtYoutubeUrl.Size = new System.Drawing.Size(275, 29);
            this.txtYoutubeUrl.TabIndex = 7;
            this.txtYoutubeUrl.Text = "rtmp://a.rtmp.youtube.com/live2";
            // 
            // txtYoutubeKey
            // 
            this.txtYoutubeKey.Location = new System.Drawing.Point(425, 19);
            this.txtYoutubeKey.Multiline = true;
            this.txtYoutubeKey.Name = "txtYoutubeKey";
            this.txtYoutubeKey.Size = new System.Drawing.Size(251, 29);
            this.txtYoutubeKey.TabIndex = 5;
            this.txtYoutubeKey.Text = "bh3h-3823-f1zh-5p97";
            // 
            // btnStopStreamYoutube
            // 
            this.btnStopStreamYoutube.Location = new System.Drawing.Point(827, 19);
            this.btnStopStreamYoutube.Name = "btnStopStreamYoutube";
            this.btnStopStreamYoutube.Size = new System.Drawing.Size(99, 29);
            this.btnStopStreamYoutube.TabIndex = 4;
            this.btnStopStreamYoutube.Text = "Stop Stream";
            this.btnStopStreamYoutube.UseVisualStyleBackColor = true;
            this.btnStopStreamYoutube.Click += new System.EventHandler(this.btnStopStreamYoutube_Click);
            // 
            // btnStreamYoutube
            // 
            this.btnStreamYoutube.Location = new System.Drawing.Point(708, 19);
            this.btnStreamYoutube.Name = "btnStreamYoutube";
            this.btnStreamYoutube.Size = new System.Drawing.Size(99, 29);
            this.btnStreamYoutube.TabIndex = 3;
            this.btnStreamYoutube.Text = "Start Stream";
            this.btnStreamYoutube.UseVisualStyleBackColor = true;
            this.btnStreamYoutube.Click += new System.EventHandler(this.btnStreamYoutube_Click);
            // 
            // Twitch
            // 
            this.Twitch.Controls.Add(this.txtTwitchUrl);
            this.Twitch.Controls.Add(this.txtTwitchKey);
            this.Twitch.Controls.Add(this.button1);
            this.Twitch.Controls.Add(this.btnStop);
            this.Twitch.Location = new System.Drawing.Point(13, 115);
            this.Twitch.Name = "Twitch";
            this.Twitch.Size = new System.Drawing.Size(942, 58);
            this.Twitch.TabIndex = 4;
            this.Twitch.TabStop = false;
            this.Twitch.Text = "Twitch";
            // 
            // txtTwitchUrl
            // 
            this.txtTwitchUrl.Location = new System.Drawing.Point(121, 17);
            this.txtTwitchUrl.Multiline = true;
            this.txtTwitchUrl.Name = "txtTwitchUrl";
            this.txtTwitchUrl.Size = new System.Drawing.Size(279, 29);
            this.txtTwitchUrl.TabIndex = 7;
            this.txtTwitchUrl.Text = "rtmp://live.twitch.tv/app";
            // 
            // txtTwitchKey
            // 
            this.txtTwitchKey.Location = new System.Drawing.Point(424, 17);
            this.txtTwitchKey.Multiline = true;
            this.txtTwitchKey.Name = "txtTwitchKey";
            this.txtTwitchKey.Size = new System.Drawing.Size(251, 29);
            this.txtTwitchKey.TabIndex = 6;
            this.txtTwitchKey.Text = "live_32096828_qv2sAThZI25nbTgzxXSNTnxYK9b8oH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSteamUrl);
            this.groupBox2.Controls.Add(this.txtSteamKey);
            this.groupBox2.Controls.Add(this.btnStopSteam);
            this.groupBox2.Controls.Add(this.btnStartSteam);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Steam";
            // 
            // txtSteamUrl
            // 
            this.txtSteamUrl.Location = new System.Drawing.Point(122, 19);
            this.txtSteamUrl.Multiline = true;
            this.txtSteamUrl.Name = "txtSteamUrl";
            this.txtSteamUrl.Size = new System.Drawing.Size(279, 29);
            this.txtSteamUrl.TabIndex = 8;
            this.txtSteamUrl.Text = "rtmp://ingest-01-hkg1.broadcast.steamcontent.com/app";
            // 
            // txtSteamKey
            // 
            this.txtSteamKey.Location = new System.Drawing.Point(425, 14);
            this.txtSteamKey.Multiline = true;
            this.txtSteamKey.Name = "txtSteamKey";
            this.txtSteamKey.Size = new System.Drawing.Size(251, 29);
            this.txtSteamKey.TabIndex = 8;
            this.txtSteamKey.Text = "steam_294584987_366a0a71f6fe1953";
            // 
            // btnStopSteam
            // 
            this.btnStopSteam.Location = new System.Drawing.Point(827, 10);
            this.btnStopSteam.Name = "btnStopSteam";
            this.btnStopSteam.Size = new System.Drawing.Size(99, 27);
            this.btnStopSteam.TabIndex = 3;
            this.btnStopSteam.Text = "Stop Stream";
            this.btnStopSteam.UseVisualStyleBackColor = true;
            this.btnStopSteam.Click += new System.EventHandler(this.btnStopSteam_Click);
            // 
            // btnStartSteam
            // 
            this.btnStartSteam.Location = new System.Drawing.Point(708, 10);
            this.btnStartSteam.Name = "btnStartSteam";
            this.btnStartSteam.Size = new System.Drawing.Size(99, 27);
            this.btnStartSteam.TabIndex = 2;
            this.btnStartSteam.Text = "Start Stream";
            this.btnStartSteam.UseVisualStyleBackColor = true;
            this.btnStartSteam.Click += new System.EventHandler(this.btnStartSteam_Click);
            // 
            // btnStopMixer
            // 
            this.btnStopMixer.Location = new System.Drawing.Point(827, 19);
            this.btnStopMixer.Name = "btnStopMixer";
            this.btnStopMixer.Size = new System.Drawing.Size(99, 27);
            this.btnStopMixer.TabIndex = 3;
            this.btnStopMixer.Text = "Stop Stream";
            this.btnStopMixer.UseVisualStyleBackColor = true;
            this.btnStopMixer.Click += new System.EventHandler(this.btnStopMixer_Click);
            // 
            // btnStartMixer
            // 
            this.btnStartMixer.Location = new System.Drawing.Point(708, 19);
            this.btnStartMixer.Name = "btnStartMixer";
            this.btnStartMixer.Size = new System.Drawing.Size(99, 27);
            this.btnStartMixer.TabIndex = 2;
            this.btnStartMixer.Text = "Start Stream";
            this.btnStartMixer.UseVisualStyleBackColor = true;
            this.btnStartMixer.Click += new System.EventHandler(this.btnStartMixer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMixerUrl);
            this.groupBox3.Controls.Add(this.txtMixerKey);
            this.groupBox3.Controls.Add(this.btnStopMixer);
            this.groupBox3.Controls.Add(this.btnStartMixer);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(943, 56);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mixer";
            // 
            // txtMixerUrl
            // 
            this.txtMixerUrl.Location = new System.Drawing.Point(122, 17);
            this.txtMixerUrl.Multiline = true;
            this.txtMixerUrl.Name = "txtMixerUrl";
            this.txtMixerUrl.Size = new System.Drawing.Size(279, 29);
            this.txtMixerUrl.TabIndex = 9;
            this.txtMixerUrl.Text = "rtmp://ingest-seo.mixer.com:1935/beam";
            // 
            // txtMixerKey
            // 
            this.txtMixerKey.Location = new System.Drawing.Point(425, 17);
            this.txtMixerKey.Multiline = true;
            this.txtMixerKey.Name = "txtMixerKey";
            this.txtMixerKey.Size = new System.Drawing.Size(251, 29);
            this.txtMixerKey.TabIndex = 9;
            this.txtMixerKey.Text = "102783594-l1gLA0JLlW7u0psYjXsv2Bn0MlN0R0lN";
            // 
            // btnStopWowza
            // 
            this.btnStopWowza.Location = new System.Drawing.Point(826, 19);
            this.btnStopWowza.Name = "btnStopWowza";
            this.btnStopWowza.Size = new System.Drawing.Size(99, 27);
            this.btnStopWowza.TabIndex = 3;
            this.btnStopWowza.Text = "Stop Stream";
            this.btnStopWowza.UseVisualStyleBackColor = true;
            this.btnStopWowza.Click += new System.EventHandler(this.btnStopWowza_Click);
            // 
            // btnStartWowza
            // 
            this.btnStartWowza.Location = new System.Drawing.Point(707, 19);
            this.btnStartWowza.Name = "btnStartWowza";
            this.btnStartWowza.Size = new System.Drawing.Size(99, 27);
            this.btnStartWowza.TabIndex = 2;
            this.btnStartWowza.Text = "Start Stream";
            this.btnStartWowza.UseVisualStyleBackColor = true;
            this.btnStartWowza.Click += new System.EventHandler(this.btnStartWowza_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWowzaUrl);
            this.groupBox4.Controls.Add(this.btnStopWowza);
            this.groupBox4.Controls.Add(this.btnStartWowza);
            this.groupBox4.Location = new System.Drawing.Point(13, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(942, 56);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wowza";
            // 
            // txtWowzaUrl
            // 
            this.txtWowzaUrl.Location = new System.Drawing.Point(121, 19);
            this.txtWowzaUrl.Multiline = true;
            this.txtWowzaUrl.Name = "txtWowzaUrl";
            this.txtWowzaUrl.Size = new System.Drawing.Size(279, 29);
            this.txtWowzaUrl.TabIndex = 10;
            this.txtWowzaUrl.Text = "rtmp://192.168.1.16:1935/live/myStream";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 427);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Twitch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Twitch.ResumeLayout(false);
            this.Twitch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoginYoutube;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStopStreamYoutube;
        private System.Windows.Forms.Button btnStreamYoutube;
        private System.Windows.Forms.GroupBox Twitch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStopSteam;
        private System.Windows.Forms.Button btnStartSteam;
        private System.Windows.Forms.Button btnStopMixer;
        private System.Windows.Forms.Button btnStartMixer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStopWowza;
        private System.Windows.Forms.Button btnStartWowza;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtYoutubeUrl;
        private System.Windows.Forms.TextBox txtYoutubeKey;
        private System.Windows.Forms.TextBox txtTwitchUrl;
        private System.Windows.Forms.TextBox txtTwitchKey;
        private System.Windows.Forms.TextBox txtSteamKey;
        private System.Windows.Forms.TextBox txtMixerKey;
        private System.Windows.Forms.TextBox txtSteamUrl;
        private System.Windows.Forms.TextBox txtMixerUrl;
        private System.Windows.Forms.TextBox txtWowzaUrl;
    }
}

