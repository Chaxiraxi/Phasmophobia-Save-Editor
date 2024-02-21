using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp4.Properties
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000029CA File Offset: 0x00000BCA
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000029D4 File Offset: 0x00000BD4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("WindowsFormsApp4.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002A1C File Offset: 0x00000C1C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002A33 File Offset: 0x00000C33
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002A3C File Offset: 0x00000C3C
		internal static Icon PH_logo_design_vector_Graphics_20834109_1_580x386__1_
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("PH_logo_design_vector_Graphics_20834109_1_580x386__1_", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x04000006 RID: 6
		private static ResourceManager resourceMan;

		// Token: 0x04000007 RID: 7
		private static CultureInfo resourceCulture;
	}
}
