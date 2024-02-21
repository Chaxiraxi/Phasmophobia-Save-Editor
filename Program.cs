using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000029AF File Offset: 0x00000BAF
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
