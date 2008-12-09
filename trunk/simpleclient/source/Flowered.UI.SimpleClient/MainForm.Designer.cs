/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 09.12.2008
 * Time: 22:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Flowered.UI.SimpleClient
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			this.tmrFetch = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// tmrFetch
			// 
			this.tmrFetch.Interval = 60000;
			this.tmrFetch.Tick += new System.EventHandler(this.TmrFetchTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Name = "MainForm";
			this.Text = "Flowered.UI.SimpleClient";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer tmrFetch;
	}
}
