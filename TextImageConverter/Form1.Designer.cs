
namespace TextImageConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ConvertTextToImage = new System.Windows.Forms.Button();
            this.ConvertImageToText = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(334, 291);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // ConvertTextToImage
            // 
            this.ConvertTextToImage.Location = new System.Drawing.Point(352, 100);
            this.ConvertTextToImage.Name = "ConvertTextToImage";
            this.ConvertTextToImage.Size = new System.Drawing.Size(156, 23);
            this.ConvertTextToImage.TabIndex = 1;
            this.ConvertTextToImage.Text = "Convert Text To Image";
            this.ConvertTextToImage.UseVisualStyleBackColor = true;
            this.ConvertTextToImage.Click += new System.EventHandler(this.ConvertTextToImage_Click);
            // 
            // ConvertImageToText
            // 
            this.ConvertImageToText.Location = new System.Drawing.Point(352, 186);
            this.ConvertImageToText.Name = "ConvertImageToText";
            this.ConvertImageToText.Size = new System.Drawing.Size(156, 23);
            this.ConvertImageToText.TabIndex = 2;
            this.ConvertImageToText.Text = "Convert Image To Text";
            this.ConvertImageToText.UseVisualStyleBackColor = true;
            this.ConvertImageToText.Click += new System.EventHandler(this.ConvertImageToText_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(514, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(374, 291);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(748, 336);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(140, 23);
            this.Export.TabIndex = 4;
            this.Export.Text = "export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(514, 336);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(130, 23);
            this.Import.TabIndex = 5;
            this.Import.Text = "import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 382);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ConvertImageToText);
            this.Controls.Add(this.ConvertTextToImage);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button ConvertTextToImage;
        private System.Windows.Forms.Button ConvertImageToText;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
    }
}

