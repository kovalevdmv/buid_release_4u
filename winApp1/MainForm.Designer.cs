/*
 * Created by SharpDevelop.
 * User: dimon
 * Date: 06.06.2016
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace winApp1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox log;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textVer;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.log = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textVer = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(204, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Создать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// log
			// 
			this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.log.Location = new System.Drawing.Point(12, 38);
			this.log.Multiline = true;
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(746, 228);
			this.log.TabIndex = 3;
			this.log.WordWrap = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Номер релиза";
			// 
			// textVer
			// 
			this.textVer.Location = new System.Drawing.Point(98, 6);
			this.textVer.Name = "textVer";
			this.textVer.Size = new System.Drawing.Size(100, 20);
			this.textVer.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(285, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Открыть папку с релизом";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(443, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(315, 31);
			this.label2.TabIndex = 7;
			this.label2.Text = "? Если существует релиз с указанным номером - открыть папку релиза иначе откроетс" +
	"я папка со всеми релизами";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 278);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textVer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.log);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Релиз Общепит";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		}
	}