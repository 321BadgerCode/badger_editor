using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace badger_editor_1
{
	public class load_1 : Form
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Task.Factory.StartNew(worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
		}

		public Action worker;
		public load_1(Action A1) { new box_1("Loading...", "Waiting for application to start...").load(); if (A1 == null) { throw new ArgumentNullException("Zoinkers scoob; the variable is null! Ruh roh raggy!"); } worker = A1; }
	};
};