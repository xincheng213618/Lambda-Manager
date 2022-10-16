using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S63
{
	public static int Invoke3(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke32XXXX(code, p, args), 
			'6' => Invoke36XXXX(code, p, args), 
			'3' => Invoke33XXXX(code, p, args), 
			'5' => Invoke35XXXX(code, p, args), 
			'7' => Invoke37XXXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke32XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke322XXX(code, p, args), 
			'6' => Invoke326XXX(code, p, args), 
			'3' => Invoke323XXX(code, p, args), 
			'5' => Invoke325XXX(code, p, args), 
			'7' => Invoke327XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke322XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3222XX(code, p, args), 
			'6' => Invoke3226XX(code, p, args), 
			'3' => Invoke3223XX(code, p, args), 
			'5' => Invoke3225XX(code, p, args), 
			'7' => Invoke3227XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3222XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32222X(code, p, args), 
			'6' => Invoke32226X(code, p, args), 
			'3' => Invoke32223X(code, p, args), 
			'5' => Invoke32225X(code, p, args), 
			'7' => Invoke32227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3226XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32262X(code, p, args), 
			'6' => Invoke32266X(code, p, args), 
			'3' => Invoke32263X(code, p, args), 
			'5' => Invoke32265X(code, p, args), 
			'7' => Invoke32267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3223XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32232X(code, p, args), 
			'6' => Invoke32236X(code, p, args), 
			'3' => Invoke32233X(code, p, args), 
			'5' => Invoke32235X(code, p, args), 
			'7' => Invoke32237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3225XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32252X(code, p, args), 
			'6' => Invoke32256X(code, p, args), 
			'3' => Invoke32253X(code, p, args), 
			'5' => Invoke32255X(code, p, args), 
			'7' => Invoke32257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3227XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32272X(code, p, args), 
			'6' => Invoke32276X(code, p, args), 
			'3' => Invoke32273X(code, p, args), 
			'5' => Invoke32275X(code, p, args), 
			'7' => Invoke32277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke326XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3262XX(code, p, args), 
			'6' => Invoke3266XX(code, p, args), 
			'3' => Invoke3263XX(code, p, args), 
			'5' => Invoke3265XX(code, p, args), 
			'7' => Invoke3267XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3262XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32622X(code, p, args), 
			'6' => Invoke32626X(code, p, args), 
			'3' => Invoke32623X(code, p, args), 
			'5' => Invoke32625X(code, p, args), 
			'7' => Invoke32627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3266XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32662X(code, p, args), 
			'6' => Invoke32666X(code, p, args), 
			'3' => Invoke32663X(code, p, args), 
			'5' => Invoke32665X(code, p, args), 
			'7' => Invoke32667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3263XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32632X(code, p, args), 
			'6' => Invoke32636X(code, p, args), 
			'3' => Invoke32633X(code, p, args), 
			'5' => Invoke32635X(code, p, args), 
			'7' => Invoke32637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3265XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32652X(code, p, args), 
			'6' => Invoke32656X(code, p, args), 
			'3' => Invoke32653X(code, p, args), 
			'5' => Invoke32655X(code, p, args), 
			'7' => Invoke32657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3267XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32672X(code, p, args), 
			'6' => Invoke32676X(code, p, args), 
			'3' => Invoke32673X(code, p, args), 
			'5' => Invoke32675X(code, p, args), 
			'7' => Invoke32677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke323XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3232XX(code, p, args), 
			'6' => Invoke3236XX(code, p, args), 
			'3' => Invoke3233XX(code, p, args), 
			'5' => Invoke3235XX(code, p, args), 
			'7' => Invoke3237XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3232XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32322X(code, p, args), 
			'6' => Invoke32326X(code, p, args), 
			'3' => Invoke32323X(code, p, args), 
			'5' => Invoke32325X(code, p, args), 
			'7' => Invoke32327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3236XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32362X(code, p, args), 
			'6' => Invoke32366X(code, p, args), 
			'3' => Invoke32363X(code, p, args), 
			'5' => Invoke32365X(code, p, args), 
			'7' => Invoke32367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3233XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32332X(code, p, args), 
			'6' => Invoke32336X(code, p, args), 
			'3' => Invoke32333X(code, p, args), 
			'5' => Invoke32335X(code, p, args), 
			'7' => Invoke32337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3235XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32352X(code, p, args), 
			'6' => Invoke32356X(code, p, args), 
			'3' => Invoke32353X(code, p, args), 
			'5' => Invoke32355X(code, p, args), 
			'7' => Invoke32357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3237XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32372X(code, p, args), 
			'6' => Invoke32376X(code, p, args), 
			'3' => Invoke32373X(code, p, args), 
			'5' => Invoke32375X(code, p, args), 
			'7' => Invoke32377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke325XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3252XX(code, p, args), 
			'6' => Invoke3256XX(code, p, args), 
			'3' => Invoke3253XX(code, p, args), 
			'5' => Invoke3255XX(code, p, args), 
			'7' => Invoke3257XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3252XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32522X(code, p, args), 
			'6' => Invoke32526X(code, p, args), 
			'3' => Invoke32523X(code, p, args), 
			'5' => Invoke32525X(code, p, args), 
			'7' => Invoke32527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3256XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32562X(code, p, args), 
			'6' => Invoke32566X(code, p, args), 
			'3' => Invoke32563X(code, p, args), 
			'5' => Invoke32565X(code, p, args), 
			'7' => Invoke32567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3253XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32532X(code, p, args), 
			'6' => Invoke32536X(code, p, args), 
			'3' => Invoke32533X(code, p, args), 
			'5' => Invoke32535X(code, p, args), 
			'7' => Invoke32537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3255XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32552X(code, p, args), 
			'6' => Invoke32556X(code, p, args), 
			'3' => Invoke32553X(code, p, args), 
			'5' => Invoke32555X(code, p, args), 
			'7' => Invoke32557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3257XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32572X(code, p, args), 
			'6' => Invoke32576X(code, p, args), 
			'3' => Invoke32573X(code, p, args), 
			'5' => Invoke32575X(code, p, args), 
			'7' => Invoke32577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke327XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3272XX(code, p, args), 
			'6' => Invoke3276XX(code, p, args), 
			'3' => Invoke3273XX(code, p, args), 
			'5' => Invoke3275XX(code, p, args), 
			'7' => Invoke3277XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3272XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32722X(code, p, args), 
			'6' => Invoke32726X(code, p, args), 
			'3' => Invoke32723X(code, p, args), 
			'5' => Invoke32725X(code, p, args), 
			'7' => Invoke32727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3276XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32762X(code, p, args), 
			'6' => Invoke32766X(code, p, args), 
			'3' => Invoke32763X(code, p, args), 
			'5' => Invoke32765X(code, p, args), 
			'7' => Invoke32767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3273XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32732X(code, p, args), 
			'6' => Invoke32736X(code, p, args), 
			'3' => Invoke32733X(code, p, args), 
			'5' => Invoke32735X(code, p, args), 
			'7' => Invoke32737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3275XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32752X(code, p, args), 
			'6' => Invoke32756X(code, p, args), 
			'3' => Invoke32753X(code, p, args), 
			'5' => Invoke32755X(code, p, args), 
			'7' => Invoke32757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3277XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke32772X(code, p, args), 
			'6' => Invoke32776X(code, p, args), 
			'3' => Invoke32773X(code, p, args), 
			'5' => Invoke32775X(code, p, args), 
			'7' => Invoke32777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke36XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke362XXX(code, p, args), 
			'6' => Invoke366XXX(code, p, args), 
			'3' => Invoke363XXX(code, p, args), 
			'5' => Invoke365XXX(code, p, args), 
			'7' => Invoke367XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke362XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3622XX(code, p, args), 
			'6' => Invoke3626XX(code, p, args), 
			'3' => Invoke3623XX(code, p, args), 
			'5' => Invoke3625XX(code, p, args), 
			'7' => Invoke3627XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3622XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36222X(code, p, args), 
			'6' => Invoke36226X(code, p, args), 
			'3' => Invoke36223X(code, p, args), 
			'5' => Invoke36225X(code, p, args), 
			'7' => Invoke36227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3626XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36262X(code, p, args), 
			'6' => Invoke36266X(code, p, args), 
			'3' => Invoke36263X(code, p, args), 
			'5' => Invoke36265X(code, p, args), 
			'7' => Invoke36267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3623XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36232X(code, p, args), 
			'6' => Invoke36236X(code, p, args), 
			'3' => Invoke36233X(code, p, args), 
			'5' => Invoke36235X(code, p, args), 
			'7' => Invoke36237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3625XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36252X(code, p, args), 
			'6' => Invoke36256X(code, p, args), 
			'3' => Invoke36253X(code, p, args), 
			'5' => Invoke36255X(code, p, args), 
			'7' => Invoke36257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3627XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36272X(code, p, args), 
			'6' => Invoke36276X(code, p, args), 
			'3' => Invoke36273X(code, p, args), 
			'5' => Invoke36275X(code, p, args), 
			'7' => Invoke36277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke366XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3662XX(code, p, args), 
			'6' => Invoke3666XX(code, p, args), 
			'3' => Invoke3663XX(code, p, args), 
			'5' => Invoke3665XX(code, p, args), 
			'7' => Invoke3667XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3662XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36622X(code, p, args), 
			'6' => Invoke36626X(code, p, args), 
			'3' => Invoke36623X(code, p, args), 
			'5' => Invoke36625X(code, p, args), 
			'7' => Invoke36627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3666XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36662X(code, p, args), 
			'6' => Invoke36666X(code, p, args), 
			'3' => Invoke36663X(code, p, args), 
			'5' => Invoke36665X(code, p, args), 
			'7' => Invoke36667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3663XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36632X(code, p, args), 
			'6' => Invoke36636X(code, p, args), 
			'3' => Invoke36633X(code, p, args), 
			'5' => Invoke36635X(code, p, args), 
			'7' => Invoke36637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3665XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36652X(code, p, args), 
			'6' => Invoke36656X(code, p, args), 
			'3' => Invoke36653X(code, p, args), 
			'5' => Invoke36655X(code, p, args), 
			'7' => Invoke36657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3667XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36672X(code, p, args), 
			'6' => Invoke36676X(code, p, args), 
			'3' => Invoke36673X(code, p, args), 
			'5' => Invoke36675X(code, p, args), 
			'7' => Invoke36677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke363XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3632XX(code, p, args), 
			'6' => Invoke3636XX(code, p, args), 
			'3' => Invoke3633XX(code, p, args), 
			'5' => Invoke3635XX(code, p, args), 
			'7' => Invoke3637XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3632XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36322X(code, p, args), 
			'6' => Invoke36326X(code, p, args), 
			'3' => Invoke36323X(code, p, args), 
			'5' => Invoke36325X(code, p, args), 
			'7' => Invoke36327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3636XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36362X(code, p, args), 
			'6' => Invoke36366X(code, p, args), 
			'3' => Invoke36363X(code, p, args), 
			'5' => Invoke36365X(code, p, args), 
			'7' => Invoke36367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3633XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36332X(code, p, args), 
			'6' => Invoke36336X(code, p, args), 
			'3' => Invoke36333X(code, p, args), 
			'5' => Invoke36335X(code, p, args), 
			'7' => Invoke36337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3635XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36352X(code, p, args), 
			'6' => Invoke36356X(code, p, args), 
			'3' => Invoke36353X(code, p, args), 
			'5' => Invoke36355X(code, p, args), 
			'7' => Invoke36357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3637XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36372X(code, p, args), 
			'6' => Invoke36376X(code, p, args), 
			'3' => Invoke36373X(code, p, args), 
			'5' => Invoke36375X(code, p, args), 
			'7' => Invoke36377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke365XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3652XX(code, p, args), 
			'6' => Invoke3656XX(code, p, args), 
			'3' => Invoke3653XX(code, p, args), 
			'5' => Invoke3655XX(code, p, args), 
			'7' => Invoke3657XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3652XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36522X(code, p, args), 
			'6' => Invoke36526X(code, p, args), 
			'3' => Invoke36523X(code, p, args), 
			'5' => Invoke36525X(code, p, args), 
			'7' => Invoke36527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3656XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36562X(code, p, args), 
			'6' => Invoke36566X(code, p, args), 
			'3' => Invoke36563X(code, p, args), 
			'5' => Invoke36565X(code, p, args), 
			'7' => Invoke36567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3653XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36532X(code, p, args), 
			'6' => Invoke36536X(code, p, args), 
			'3' => Invoke36533X(code, p, args), 
			'5' => Invoke36535X(code, p, args), 
			'7' => Invoke36537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3655XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36552X(code, p, args), 
			'6' => Invoke36556X(code, p, args), 
			'3' => Invoke36553X(code, p, args), 
			'5' => Invoke36555X(code, p, args), 
			'7' => Invoke36557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3657XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36572X(code, p, args), 
			'6' => Invoke36576X(code, p, args), 
			'3' => Invoke36573X(code, p, args), 
			'5' => Invoke36575X(code, p, args), 
			'7' => Invoke36577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke367XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3672XX(code, p, args), 
			'6' => Invoke3676XX(code, p, args), 
			'3' => Invoke3673XX(code, p, args), 
			'5' => Invoke3675XX(code, p, args), 
			'7' => Invoke3677XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3672XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36722X(code, p, args), 
			'6' => Invoke36726X(code, p, args), 
			'3' => Invoke36723X(code, p, args), 
			'5' => Invoke36725X(code, p, args), 
			'7' => Invoke36727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3676XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36762X(code, p, args), 
			'6' => Invoke36766X(code, p, args), 
			'3' => Invoke36763X(code, p, args), 
			'5' => Invoke36765X(code, p, args), 
			'7' => Invoke36767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3673XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36732X(code, p, args), 
			'6' => Invoke36736X(code, p, args), 
			'3' => Invoke36733X(code, p, args), 
			'5' => Invoke36735X(code, p, args), 
			'7' => Invoke36737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3675XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36752X(code, p, args), 
			'6' => Invoke36756X(code, p, args), 
			'3' => Invoke36753X(code, p, args), 
			'5' => Invoke36755X(code, p, args), 
			'7' => Invoke36757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3677XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke36772X(code, p, args), 
			'6' => Invoke36776X(code, p, args), 
			'3' => Invoke36773X(code, p, args), 
			'5' => Invoke36775X(code, p, args), 
			'7' => Invoke36777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke33XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke332XXX(code, p, args), 
			'6' => Invoke336XXX(code, p, args), 
			'3' => Invoke333XXX(code, p, args), 
			'5' => Invoke335XXX(code, p, args), 
			'7' => Invoke337XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke332XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3322XX(code, p, args), 
			'6' => Invoke3326XX(code, p, args), 
			'3' => Invoke3323XX(code, p, args), 
			'5' => Invoke3325XX(code, p, args), 
			'7' => Invoke3327XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3322XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33222X(code, p, args), 
			'6' => Invoke33226X(code, p, args), 
			'3' => Invoke33223X(code, p, args), 
			'5' => Invoke33225X(code, p, args), 
			'7' => Invoke33227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3326XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33262X(code, p, args), 
			'6' => Invoke33266X(code, p, args), 
			'3' => Invoke33263X(code, p, args), 
			'5' => Invoke33265X(code, p, args), 
			'7' => Invoke33267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3323XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33232X(code, p, args), 
			'6' => Invoke33236X(code, p, args), 
			'3' => Invoke33233X(code, p, args), 
			'5' => Invoke33235X(code, p, args), 
			'7' => Invoke33237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3325XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33252X(code, p, args), 
			'6' => Invoke33256X(code, p, args), 
			'3' => Invoke33253X(code, p, args), 
			'5' => Invoke33255X(code, p, args), 
			'7' => Invoke33257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3327XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33272X(code, p, args), 
			'6' => Invoke33276X(code, p, args), 
			'3' => Invoke33273X(code, p, args), 
			'5' => Invoke33275X(code, p, args), 
			'7' => Invoke33277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke336XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3362XX(code, p, args), 
			'6' => Invoke3366XX(code, p, args), 
			'3' => Invoke3363XX(code, p, args), 
			'5' => Invoke3365XX(code, p, args), 
			'7' => Invoke3367XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3362XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33622X(code, p, args), 
			'6' => Invoke33626X(code, p, args), 
			'3' => Invoke33623X(code, p, args), 
			'5' => Invoke33625X(code, p, args), 
			'7' => Invoke33627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3366XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33662X(code, p, args), 
			'6' => Invoke33666X(code, p, args), 
			'3' => Invoke33663X(code, p, args), 
			'5' => Invoke33665X(code, p, args), 
			'7' => Invoke33667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3363XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33632X(code, p, args), 
			'6' => Invoke33636X(code, p, args), 
			'3' => Invoke33633X(code, p, args), 
			'5' => Invoke33635X(code, p, args), 
			'7' => Invoke33637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3365XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33652X(code, p, args), 
			'6' => Invoke33656X(code, p, args), 
			'3' => Invoke33653X(code, p, args), 
			'5' => Invoke33655X(code, p, args), 
			'7' => Invoke33657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3367XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33672X(code, p, args), 
			'6' => Invoke33676X(code, p, args), 
			'3' => Invoke33673X(code, p, args), 
			'5' => Invoke33675X(code, p, args), 
			'7' => Invoke33677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke333XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3332XX(code, p, args), 
			'6' => Invoke3336XX(code, p, args), 
			'3' => Invoke3333XX(code, p, args), 
			'5' => Invoke3335XX(code, p, args), 
			'7' => Invoke3337XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3332XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33322X(code, p, args), 
			'6' => Invoke33326X(code, p, args), 
			'3' => Invoke33323X(code, p, args), 
			'5' => Invoke33325X(code, p, args), 
			'7' => Invoke33327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3336XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33362X(code, p, args), 
			'6' => Invoke33366X(code, p, args), 
			'3' => Invoke33363X(code, p, args), 
			'5' => Invoke33365X(code, p, args), 
			'7' => Invoke33367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3333XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33332X(code, p, args), 
			'6' => Invoke33336X(code, p, args), 
			'3' => Invoke33333X(code, p, args), 
			'5' => Invoke33335X(code, p, args), 
			'7' => Invoke33337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3335XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33352X(code, p, args), 
			'6' => Invoke33356X(code, p, args), 
			'3' => Invoke33353X(code, p, args), 
			'5' => Invoke33355X(code, p, args), 
			'7' => Invoke33357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3337XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33372X(code, p, args), 
			'6' => Invoke33376X(code, p, args), 
			'3' => Invoke33373X(code, p, args), 
			'5' => Invoke33375X(code, p, args), 
			'7' => Invoke33377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke335XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3352XX(code, p, args), 
			'6' => Invoke3356XX(code, p, args), 
			'3' => Invoke3353XX(code, p, args), 
			'5' => Invoke3355XX(code, p, args), 
			'7' => Invoke3357XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3352XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33522X(code, p, args), 
			'6' => Invoke33526X(code, p, args), 
			'3' => Invoke33523X(code, p, args), 
			'5' => Invoke33525X(code, p, args), 
			'7' => Invoke33527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3356XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33562X(code, p, args), 
			'6' => Invoke33566X(code, p, args), 
			'3' => Invoke33563X(code, p, args), 
			'5' => Invoke33565X(code, p, args), 
			'7' => Invoke33567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3353XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33532X(code, p, args), 
			'6' => Invoke33536X(code, p, args), 
			'3' => Invoke33533X(code, p, args), 
			'5' => Invoke33535X(code, p, args), 
			'7' => Invoke33537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3355XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33552X(code, p, args), 
			'6' => Invoke33556X(code, p, args), 
			'3' => Invoke33553X(code, p, args), 
			'5' => Invoke33555X(code, p, args), 
			'7' => Invoke33557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3357XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33572X(code, p, args), 
			'6' => Invoke33576X(code, p, args), 
			'3' => Invoke33573X(code, p, args), 
			'5' => Invoke33575X(code, p, args), 
			'7' => Invoke33577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke337XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3372XX(code, p, args), 
			'6' => Invoke3376XX(code, p, args), 
			'3' => Invoke3373XX(code, p, args), 
			'5' => Invoke3375XX(code, p, args), 
			'7' => Invoke3377XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3372XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33722X(code, p, args), 
			'6' => Invoke33726X(code, p, args), 
			'3' => Invoke33723X(code, p, args), 
			'5' => Invoke33725X(code, p, args), 
			'7' => Invoke33727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3376XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33762X(code, p, args), 
			'6' => Invoke33766X(code, p, args), 
			'3' => Invoke33763X(code, p, args), 
			'5' => Invoke33765X(code, p, args), 
			'7' => Invoke33767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3373XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33732X(code, p, args), 
			'6' => Invoke33736X(code, p, args), 
			'3' => Invoke33733X(code, p, args), 
			'5' => Invoke33735X(code, p, args), 
			'7' => Invoke33737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3375XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33752X(code, p, args), 
			'6' => Invoke33756X(code, p, args), 
			'3' => Invoke33753X(code, p, args), 
			'5' => Invoke33755X(code, p, args), 
			'7' => Invoke33757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3377XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke33772X(code, p, args), 
			'6' => Invoke33776X(code, p, args), 
			'3' => Invoke33773X(code, p, args), 
			'5' => Invoke33775X(code, p, args), 
			'7' => Invoke33777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke35XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke352XXX(code, p, args), 
			'6' => Invoke356XXX(code, p, args), 
			'3' => Invoke353XXX(code, p, args), 
			'5' => Invoke355XXX(code, p, args), 
			'7' => Invoke357XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke352XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3522XX(code, p, args), 
			'6' => Invoke3526XX(code, p, args), 
			'3' => Invoke3523XX(code, p, args), 
			'5' => Invoke3525XX(code, p, args), 
			'7' => Invoke3527XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3522XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35222X(code, p, args), 
			'6' => Invoke35226X(code, p, args), 
			'3' => Invoke35223X(code, p, args), 
			'5' => Invoke35225X(code, p, args), 
			'7' => Invoke35227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3526XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35262X(code, p, args), 
			'6' => Invoke35266X(code, p, args), 
			'3' => Invoke35263X(code, p, args), 
			'5' => Invoke35265X(code, p, args), 
			'7' => Invoke35267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3523XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35232X(code, p, args), 
			'6' => Invoke35236X(code, p, args), 
			'3' => Invoke35233X(code, p, args), 
			'5' => Invoke35235X(code, p, args), 
			'7' => Invoke35237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3525XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35252X(code, p, args), 
			'6' => Invoke35256X(code, p, args), 
			'3' => Invoke35253X(code, p, args), 
			'5' => Invoke35255X(code, p, args), 
			'7' => Invoke35257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3527XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35272X(code, p, args), 
			'6' => Invoke35276X(code, p, args), 
			'3' => Invoke35273X(code, p, args), 
			'5' => Invoke35275X(code, p, args), 
			'7' => Invoke35277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke356XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3562XX(code, p, args), 
			'6' => Invoke3566XX(code, p, args), 
			'3' => Invoke3563XX(code, p, args), 
			'5' => Invoke3565XX(code, p, args), 
			'7' => Invoke3567XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3562XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35622X(code, p, args), 
			'6' => Invoke35626X(code, p, args), 
			'3' => Invoke35623X(code, p, args), 
			'5' => Invoke35625X(code, p, args), 
			'7' => Invoke35627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3566XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35662X(code, p, args), 
			'6' => Invoke35666X(code, p, args), 
			'3' => Invoke35663X(code, p, args), 
			'5' => Invoke35665X(code, p, args), 
			'7' => Invoke35667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3563XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35632X(code, p, args), 
			'6' => Invoke35636X(code, p, args), 
			'3' => Invoke35633X(code, p, args), 
			'5' => Invoke35635X(code, p, args), 
			'7' => Invoke35637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3565XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35652X(code, p, args), 
			'6' => Invoke35656X(code, p, args), 
			'3' => Invoke35653X(code, p, args), 
			'5' => Invoke35655X(code, p, args), 
			'7' => Invoke35657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3567XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35672X(code, p, args), 
			'6' => Invoke35676X(code, p, args), 
			'3' => Invoke35673X(code, p, args), 
			'5' => Invoke35675X(code, p, args), 
			'7' => Invoke35677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke353XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3532XX(code, p, args), 
			'6' => Invoke3536XX(code, p, args), 
			'3' => Invoke3533XX(code, p, args), 
			'5' => Invoke3535XX(code, p, args), 
			'7' => Invoke3537XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3532XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35322X(code, p, args), 
			'6' => Invoke35326X(code, p, args), 
			'3' => Invoke35323X(code, p, args), 
			'5' => Invoke35325X(code, p, args), 
			'7' => Invoke35327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3536XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35362X(code, p, args), 
			'6' => Invoke35366X(code, p, args), 
			'3' => Invoke35363X(code, p, args), 
			'5' => Invoke35365X(code, p, args), 
			'7' => Invoke35367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3533XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35332X(code, p, args), 
			'6' => Invoke35336X(code, p, args), 
			'3' => Invoke35333X(code, p, args), 
			'5' => Invoke35335X(code, p, args), 
			'7' => Invoke35337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3535XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35352X(code, p, args), 
			'6' => Invoke35356X(code, p, args), 
			'3' => Invoke35353X(code, p, args), 
			'5' => Invoke35355X(code, p, args), 
			'7' => Invoke35357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3537XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35372X(code, p, args), 
			'6' => Invoke35376X(code, p, args), 
			'3' => Invoke35373X(code, p, args), 
			'5' => Invoke35375X(code, p, args), 
			'7' => Invoke35377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke355XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3552XX(code, p, args), 
			'6' => Invoke3556XX(code, p, args), 
			'3' => Invoke3553XX(code, p, args), 
			'5' => Invoke3555XX(code, p, args), 
			'7' => Invoke3557XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3552XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35522X(code, p, args), 
			'6' => Invoke35526X(code, p, args), 
			'3' => Invoke35523X(code, p, args), 
			'5' => Invoke35525X(code, p, args), 
			'7' => Invoke35527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3556XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35562X(code, p, args), 
			'6' => Invoke35566X(code, p, args), 
			'3' => Invoke35563X(code, p, args), 
			'5' => Invoke35565X(code, p, args), 
			'7' => Invoke35567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3553XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35532X(code, p, args), 
			'6' => Invoke35536X(code, p, args), 
			'3' => Invoke35533X(code, p, args), 
			'5' => Invoke35535X(code, p, args), 
			'7' => Invoke35537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3555XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35552X(code, p, args), 
			'6' => Invoke35556X(code, p, args), 
			'3' => Invoke35553X(code, p, args), 
			'5' => Invoke35555X(code, p, args), 
			'7' => Invoke35557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3557XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35572X(code, p, args), 
			'6' => Invoke35576X(code, p, args), 
			'3' => Invoke35573X(code, p, args), 
			'5' => Invoke35575X(code, p, args), 
			'7' => Invoke35577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke357XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3572XX(code, p, args), 
			'6' => Invoke3576XX(code, p, args), 
			'3' => Invoke3573XX(code, p, args), 
			'5' => Invoke3575XX(code, p, args), 
			'7' => Invoke3577XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3572XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35722X(code, p, args), 
			'6' => Invoke35726X(code, p, args), 
			'3' => Invoke35723X(code, p, args), 
			'5' => Invoke35725X(code, p, args), 
			'7' => Invoke35727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3576XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35762X(code, p, args), 
			'6' => Invoke35766X(code, p, args), 
			'3' => Invoke35763X(code, p, args), 
			'5' => Invoke35765X(code, p, args), 
			'7' => Invoke35767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3573XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35732X(code, p, args), 
			'6' => Invoke35736X(code, p, args), 
			'3' => Invoke35733X(code, p, args), 
			'5' => Invoke35735X(code, p, args), 
			'7' => Invoke35737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3575XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35752X(code, p, args), 
			'6' => Invoke35756X(code, p, args), 
			'3' => Invoke35753X(code, p, args), 
			'5' => Invoke35755X(code, p, args), 
			'7' => Invoke35757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3577XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke35772X(code, p, args), 
			'6' => Invoke35776X(code, p, args), 
			'3' => Invoke35773X(code, p, args), 
			'5' => Invoke35775X(code, p, args), 
			'7' => Invoke35777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke37XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke372XXX(code, p, args), 
			'6' => Invoke376XXX(code, p, args), 
			'3' => Invoke373XXX(code, p, args), 
			'5' => Invoke375XXX(code, p, args), 
			'7' => Invoke377XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke372XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3722XX(code, p, args), 
			'6' => Invoke3726XX(code, p, args), 
			'3' => Invoke3723XX(code, p, args), 
			'5' => Invoke3725XX(code, p, args), 
			'7' => Invoke3727XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3722XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37222X(code, p, args), 
			'6' => Invoke37226X(code, p, args), 
			'3' => Invoke37223X(code, p, args), 
			'5' => Invoke37225X(code, p, args), 
			'7' => Invoke37227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3726XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37262X(code, p, args), 
			'6' => Invoke37266X(code, p, args), 
			'3' => Invoke37263X(code, p, args), 
			'5' => Invoke37265X(code, p, args), 
			'7' => Invoke37267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3723XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37232X(code, p, args), 
			'6' => Invoke37236X(code, p, args), 
			'3' => Invoke37233X(code, p, args), 
			'5' => Invoke37235X(code, p, args), 
			'7' => Invoke37237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3725XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37252X(code, p, args), 
			'6' => Invoke37256X(code, p, args), 
			'3' => Invoke37253X(code, p, args), 
			'5' => Invoke37255X(code, p, args), 
			'7' => Invoke37257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3727XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37272X(code, p, args), 
			'6' => Invoke37276X(code, p, args), 
			'3' => Invoke37273X(code, p, args), 
			'5' => Invoke37275X(code, p, args), 
			'7' => Invoke37277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke376XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3762XX(code, p, args), 
			'6' => Invoke3766XX(code, p, args), 
			'3' => Invoke3763XX(code, p, args), 
			'5' => Invoke3765XX(code, p, args), 
			'7' => Invoke3767XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3762XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37622X(code, p, args), 
			'6' => Invoke37626X(code, p, args), 
			'3' => Invoke37623X(code, p, args), 
			'5' => Invoke37625X(code, p, args), 
			'7' => Invoke37627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3766XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37662X(code, p, args), 
			'6' => Invoke37666X(code, p, args), 
			'3' => Invoke37663X(code, p, args), 
			'5' => Invoke37665X(code, p, args), 
			'7' => Invoke37667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3763XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37632X(code, p, args), 
			'6' => Invoke37636X(code, p, args), 
			'3' => Invoke37633X(code, p, args), 
			'5' => Invoke37635X(code, p, args), 
			'7' => Invoke37637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3765XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37652X(code, p, args), 
			'6' => Invoke37656X(code, p, args), 
			'3' => Invoke37653X(code, p, args), 
			'5' => Invoke37655X(code, p, args), 
			'7' => Invoke37657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3767XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37672X(code, p, args), 
			'6' => Invoke37676X(code, p, args), 
			'3' => Invoke37673X(code, p, args), 
			'5' => Invoke37675X(code, p, args), 
			'7' => Invoke37677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke373XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3732XX(code, p, args), 
			'6' => Invoke3736XX(code, p, args), 
			'3' => Invoke3733XX(code, p, args), 
			'5' => Invoke3735XX(code, p, args), 
			'7' => Invoke3737XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3732XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37322X(code, p, args), 
			'6' => Invoke37326X(code, p, args), 
			'3' => Invoke37323X(code, p, args), 
			'5' => Invoke37325X(code, p, args), 
			'7' => Invoke37327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3736XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37362X(code, p, args), 
			'6' => Invoke37366X(code, p, args), 
			'3' => Invoke37363X(code, p, args), 
			'5' => Invoke37365X(code, p, args), 
			'7' => Invoke37367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3733XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37332X(code, p, args), 
			'6' => Invoke37336X(code, p, args), 
			'3' => Invoke37333X(code, p, args), 
			'5' => Invoke37335X(code, p, args), 
			'7' => Invoke37337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3735XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37352X(code, p, args), 
			'6' => Invoke37356X(code, p, args), 
			'3' => Invoke37353X(code, p, args), 
			'5' => Invoke37355X(code, p, args), 
			'7' => Invoke37357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3737XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37372X(code, p, args), 
			'6' => Invoke37376X(code, p, args), 
			'3' => Invoke37373X(code, p, args), 
			'5' => Invoke37375X(code, p, args), 
			'7' => Invoke37377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke375XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3752XX(code, p, args), 
			'6' => Invoke3756XX(code, p, args), 
			'3' => Invoke3753XX(code, p, args), 
			'5' => Invoke3755XX(code, p, args), 
			'7' => Invoke3757XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3752XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37522X(code, p, args), 
			'6' => Invoke37526X(code, p, args), 
			'3' => Invoke37523X(code, p, args), 
			'5' => Invoke37525X(code, p, args), 
			'7' => Invoke37527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3756XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37562X(code, p, args), 
			'6' => Invoke37566X(code, p, args), 
			'3' => Invoke37563X(code, p, args), 
			'5' => Invoke37565X(code, p, args), 
			'7' => Invoke37567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3753XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37532X(code, p, args), 
			'6' => Invoke37536X(code, p, args), 
			'3' => Invoke37533X(code, p, args), 
			'5' => Invoke37535X(code, p, args), 
			'7' => Invoke37537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3755XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37552X(code, p, args), 
			'6' => Invoke37556X(code, p, args), 
			'3' => Invoke37553X(code, p, args), 
			'5' => Invoke37555X(code, p, args), 
			'7' => Invoke37557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3757XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37572X(code, p, args), 
			'6' => Invoke37576X(code, p, args), 
			'3' => Invoke37573X(code, p, args), 
			'5' => Invoke37575X(code, p, args), 
			'7' => Invoke37577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke377XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3772XX(code, p, args), 
			'6' => Invoke3776XX(code, p, args), 
			'3' => Invoke3773XX(code, p, args), 
			'5' => Invoke3775XX(code, p, args), 
			'7' => Invoke3777XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3772XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37722X(code, p, args), 
			'6' => Invoke37726X(code, p, args), 
			'3' => Invoke37723X(code, p, args), 
			'5' => Invoke37725X(code, p, args), 
			'7' => Invoke37727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3776XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37762X(code, p, args), 
			'6' => Invoke37766X(code, p, args), 
			'3' => Invoke37763X(code, p, args), 
			'5' => Invoke37765X(code, p, args), 
			'7' => Invoke37767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3773XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37732X(code, p, args), 
			'6' => Invoke37736X(code, p, args), 
			'3' => Invoke37733X(code, p, args), 
			'5' => Invoke37735X(code, p, args), 
			'7' => Invoke37737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3775XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37752X(code, p, args), 
			'6' => Invoke37756X(code, p, args), 
			'3' => Invoke37753X(code, p, args), 
			'5' => Invoke37755X(code, p, args), 
			'7' => Invoke37757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3777XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke37772X(code, p, args), 
			'6' => Invoke37776X(code, p, args), 
			'3' => Invoke37773X(code, p, args), 
			'5' => Invoke37775X(code, p, args), 
			'7' => Invoke37777X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, int, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, int, int, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, int, int, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, int, int, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, int, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, int, float, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, int, float, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, int, float, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, int, float, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, int, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, int, long, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, int, long, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, int, long, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, int, long, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, int, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, int, double, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, int, double, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, int, double, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, int, double, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, int, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, int, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, int, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, int, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, int, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, float, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, float, int, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, float, int, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, float, int, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, float, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, float, float, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, float, float, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, float, float, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, float, float, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, float, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, float, long, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, float, long, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, float, long, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, float, long, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, float, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, float, double, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, float, double, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, float, double, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, float, double, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, float, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, float, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, float, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, float, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, float, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, long, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, long, int, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, long, int, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, long, int, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, long, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, long, float, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, long, float, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, long, float, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, long, float, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, long, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, long, long, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, long, long, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, long, long, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, long, long, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, long, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, long, double, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, long, double, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, long, double, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, long, double, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, long, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, long, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, long, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, long, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, long, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, double, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, double, int, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, double, int, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, double, int, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, double, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, double, float, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, double, float, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, double, float, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, double, float, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, double, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, double, long, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, double, long, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, double, long, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, double, long, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, double, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, double, double, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, double, double, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, double, double, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, double, double, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, double, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, double, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, double, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, double, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, double, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, int, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, int, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, int, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, float, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, float, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, float, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, float, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, long, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, long, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, long, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, long, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, double, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, double, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, double, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, double, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, int, int, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, int, int, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, int, int, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, int, int, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, int, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, int, float, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, int, float, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, int, float, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, int, float, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, int, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, int, long, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, int, long, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, int, long, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, int, long, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, int, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, int, double, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, int, double, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, int, double, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, int, double, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, int, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, int, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, int, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, int, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, int, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, float, int, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, float, int, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, float, int, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, float, int, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, float, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, float, float, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, float, float, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, float, float, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, float, float, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, float, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, float, long, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, float, long, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, float, long, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, float, long, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, float, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, float, double, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, float, double, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, float, double, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, float, double, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, float, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, float, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, float, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, float, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, float, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, long, int, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, long, int, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, long, int, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, long, int, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, long, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, long, float, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, long, float, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, long, float, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, long, float, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, long, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, long, long, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, long, long, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, long, long, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, long, long, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, long, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, long, double, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, long, double, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, long, double, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, long, double, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, long, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, long, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, long, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, long, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, long, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, double, int, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, double, int, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, double, int, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, double, int, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, double, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, double, float, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, double, float, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, double, float, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, double, float, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, double, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, double, long, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, double, long, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, double, long, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, double, long, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, double, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, double, double, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, double, double, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, double, double, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, double, double, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, double, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, double, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, double, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, double, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, double, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, int, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, int, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, int, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, int, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, float, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, float, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, float, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, float, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, long, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, long, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, long, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, long, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, double, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, double, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, double, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, double, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, int, int, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, int, int, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, int, int, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, int, int, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, int, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, int, float, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, int, float, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, int, float, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, int, float, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, int, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, int, long, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, int, long, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, int, long, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, int, long, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, int, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, int, double, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, int, double, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, int, double, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, int, double, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, int, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, int, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, int, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, int, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, int, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, float, int, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, float, int, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, float, int, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, float, int, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, float, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, float, float, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, float, float, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, float, float, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, float, float, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, float, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, float, long, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, float, long, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, float, long, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, float, long, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, float, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, float, double, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, float, double, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, float, double, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, float, double, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, float, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, float, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, float, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, float, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, float, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, long, int, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, long, int, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, long, int, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, long, int, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, long, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, long, float, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, long, float, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, long, float, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, long, float, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, long, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, long, long, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, long, long, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, long, long, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, long, long, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, long, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, long, double, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, long, double, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, long, double, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, long, double, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, long, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, long, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, long, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, long, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, long, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, double, int, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, double, int, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, double, int, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, double, int, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, double, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, double, float, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, double, float, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, double, float, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, double, float, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, double, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, double, long, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, double, long, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, double, long, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, double, long, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, double, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, double, double, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, double, double, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, double, double, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, double, double, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, double, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, double, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, double, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, double, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, double, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, int, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, int, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, int, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, int, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, float, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, float, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, float, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, float, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, long, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, long, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, long, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, long, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, double, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, double, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, double, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, double, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, int, int, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, int, int, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, int, int, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, int, int, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, int, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, int, float, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, int, float, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, int, float, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, int, float, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, int, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, int, long, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, int, long, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, int, long, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, int, long, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, int, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, int, double, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, int, double, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, int, double, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, int, double, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, int, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, int, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, int, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, int, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, int, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, float, int, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, float, int, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, float, int, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, float, int, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, float, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, float, float, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, float, float, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, float, float, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, float, float, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, float, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, float, long, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, float, long, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, float, long, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, float, long, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, float, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, float, double, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, float, double, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, float, double, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, float, double, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, float, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, float, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, float, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, float, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, float, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, long, int, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, long, int, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, long, int, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, long, int, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, long, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, long, float, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, long, float, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, long, float, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, long, float, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, long, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, long, long, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, long, long, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, long, long, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, long, long, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, long, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, long, double, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, long, double, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, long, double, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, long, double, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, long, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, long, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, long, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, long, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, long, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, double, int, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, double, int, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, double, int, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, double, int, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, double, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, double, float, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, double, float, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, double, float, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, double, float, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, double, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, double, long, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, double, long, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, double, long, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, double, long, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, double, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, double, double, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, double, double, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, double, double, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, double, double, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, double, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, double, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, double, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, double, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, double, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, int, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, int, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, int, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, int, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, float, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, float, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, float, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, float, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, long, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, long, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, long, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, long, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, double, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, double, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, double, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, double, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, int, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, int, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, int, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, int, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, float, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, float, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, float, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, float, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, long, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, long, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, long, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, long, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, double, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, double, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, double, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, double, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, int, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, int, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, int, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, int, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, float, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, float, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, float, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, float, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, long, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, long, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, long, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, long, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, double, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, double, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, double, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, double, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, int, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, int, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, int, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, int, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, float, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, float, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, float, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, float, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, long, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, long, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, long, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, long, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, double, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, double, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, double, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, double, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, int, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, int, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, int, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, int, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, float, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, float, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, float, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, float, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, long, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, long, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, long, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, long, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, double, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, double, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, double, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, double, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, int, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, int, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, int, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, int, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, float, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, float, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, float, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, float, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, long, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, long, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, long, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, long, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, double, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, double, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, double, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, double, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke32777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, int, int, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, int, int, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, int, int, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, int, int, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, int, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, int, float, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, int, float, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, int, float, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, int, float, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, int, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, int, long, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, int, long, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, int, long, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, int, long, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, int, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, int, double, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, int, double, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, int, double, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, int, double, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, int, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, int, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, int, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, int, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, int, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, float, int, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, float, int, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, float, int, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, float, int, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, float, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, float, float, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, float, float, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, float, float, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, float, float, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, float, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, float, long, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, float, long, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, float, long, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, float, long, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, float, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, float, double, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, float, double, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, float, double, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, float, double, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, float, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, float, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, float, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, float, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, float, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, long, int, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, long, int, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, long, int, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, long, int, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, long, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, long, float, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, long, float, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, long, float, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, long, float, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, long, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, long, long, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, long, long, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, long, long, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, long, long, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, long, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, long, double, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, long, double, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, long, double, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, long, double, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, long, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, long, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, long, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, long, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, long, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, double, int, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, double, int, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, double, int, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, double, int, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, double, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, double, float, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, double, float, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, double, float, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, double, float, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, double, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, double, long, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, double, long, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, double, long, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, double, long, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, double, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, double, double, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, double, double, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, double, double, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, double, double, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, double, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, double, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, double, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, double, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, double, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, int, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, int, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, int, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, int, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, float, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, float, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, float, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, float, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, long, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, long, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, long, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, long, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, double, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, double, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, double, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, double, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, int, int, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, int, int, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, int, int, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, int, int, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, int, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, int, float, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, int, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, int, float, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, int, float, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, int, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, int, long, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, int, long, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, int, long, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, int, long, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, int, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, int, double, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, int, double, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, int, double, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, int, double, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, int, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, int, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, int, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, int, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, int, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, float, int, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, float, int, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, float, int, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, float, int, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, float, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, float, float, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, float, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, float, float, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, float, float, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, float, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, float, long, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, float, long, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, float, long, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, float, long, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, float, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, float, double, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, float, double, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, float, double, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, float, double, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, float, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, float, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, float, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, float, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, float, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, long, int, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, long, int, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, long, int, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, long, int, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, long, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, long, float, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, long, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, long, float, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, long, float, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, long, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, long, long, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, long, long, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, long, long, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, long, long, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, long, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, long, double, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, long, double, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, long, double, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, long, double, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, long, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, long, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, long, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, long, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, long, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, double, int, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, double, int, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, double, int, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, double, int, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, double, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, double, float, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, double, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, double, float, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, double, float, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, double, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, double, long, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, double, long, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, double, long, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, double, long, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, double, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, double, double, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, double, double, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, double, double, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, double, double, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, double, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, double, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, double, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, double, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, double, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, int, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, int, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, int, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, int, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, float, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, float, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, float, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, long, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, long, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, long, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, long, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, double, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, double, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, double, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, double, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, int, int, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, int, int, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, int, int, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, int, int, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, int, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, int, float, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, int, float, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, int, float, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, int, float, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, int, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, int, long, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, int, long, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, int, long, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, int, long, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, int, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, int, double, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, int, double, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, int, double, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, int, double, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, int, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, int, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, int, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, int, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, int, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, float, int, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, float, int, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, float, int, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, float, int, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, float, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, float, float, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, float, float, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, float, float, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, float, float, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, float, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, float, long, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, float, long, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, float, long, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, float, long, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, float, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, float, double, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, float, double, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, float, double, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, float, double, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, float, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, float, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, float, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, float, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, float, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, long, int, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, long, int, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, long, int, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, long, int, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, long, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, long, float, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, long, float, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, long, float, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, long, float, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, long, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, long, long, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, long, long, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, long, long, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, long, long, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, long, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, long, double, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, long, double, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, long, double, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, long, double, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, long, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, long, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, long, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, long, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, long, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, double, int, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, double, int, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, double, int, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, double, int, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, double, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, double, float, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, double, float, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, double, float, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, double, float, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, double, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, double, long, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, double, long, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, double, long, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, double, long, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, double, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, double, double, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, double, double, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, double, double, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, double, double, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, double, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, double, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, double, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, double, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, double, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, int, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, int, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, int, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, int, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, float, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, float, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, float, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, float, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, long, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, long, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, long, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, long, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, double, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, double, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, double, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, double, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, int, int, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, int, int, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, int, int, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, int, int, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, int, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, int, float, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, int, float, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, int, float, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, int, float, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, int, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, int, long, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, int, long, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, int, long, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, int, long, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, int, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, int, double, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, int, double, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, int, double, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, int, double, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, int, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, int, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, int, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, int, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, int, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, float, int, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, float, int, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, float, int, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, float, int, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, float, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, float, float, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, float, float, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, float, float, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, float, float, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, float, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, float, long, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, float, long, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, float, long, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, float, long, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, float, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, float, double, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, float, double, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, float, double, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, float, double, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, float, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, float, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, float, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, float, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, float, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, long, int, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, long, int, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, long, int, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, long, int, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, long, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, long, float, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, long, float, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, long, float, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, long, float, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, long, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, long, long, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, long, long, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, long, long, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, long, long, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, long, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, long, double, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, long, double, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, long, double, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, long, double, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, long, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, long, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, long, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, long, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, long, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, double, int, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, double, int, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, double, int, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, double, int, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, double, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, double, float, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, double, float, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, double, float, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, double, float, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, double, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, double, long, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, double, long, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, double, long, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, double, long, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, double, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, double, double, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, double, double, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, double, double, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, double, double, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, double, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, double, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, double, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, double, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, double, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, int, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, int, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, int, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, int, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, float, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, float, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, float, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, float, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, long, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, long, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, long, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, long, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, double, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, double, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, double, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, double, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, int, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, int, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, int, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, int, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, float, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, float, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, float, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, float, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, long, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, long, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, long, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, long, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, double, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, double, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, double, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, double, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, int, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, int, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, int, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, int, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, float, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, float, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, float, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, float, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, long, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, long, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, long, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, long, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, double, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, double, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, double, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, double, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, int, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, int, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, int, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, int, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, float, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, float, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, float, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, float, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, long, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, long, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, long, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, long, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, double, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, double, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, double, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, double, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, int, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, int, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, int, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, int, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, float, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, float, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, float, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, float, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, long, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, long, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, long, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, long, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, double, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, double, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, double, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, double, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, int, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, int, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, int, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, int, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, float, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, float, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, float, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, float, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, long, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, long, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, long, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, long, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, double, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, double, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, double, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, double, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke36777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, int, int, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, int, int, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, int, int, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, int, int, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, int, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, int, float, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, int, float, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, int, float, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, int, float, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, int, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, int, long, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, int, long, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, int, long, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, int, long, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, int, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, int, double, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, int, double, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, int, double, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, int, double, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, int, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, int, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, int, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, int, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, int, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, float, int, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, float, int, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, float, int, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, float, int, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, float, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, float, float, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, float, float, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, float, float, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, float, float, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, float, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, float, long, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, float, long, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, float, long, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, float, long, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, float, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, float, double, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, float, double, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, float, double, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, float, double, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, float, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, float, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, float, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, float, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, float, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, long, int, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, long, int, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, long, int, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, long, int, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, long, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, long, float, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, long, float, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, long, float, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, long, float, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, long, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, long, double, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, long, double, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, long, double, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, long, double, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, long, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, long, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, long, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, long, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, long, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, double, int, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, double, int, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, double, int, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, double, int, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, double, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, double, float, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, double, float, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, double, float, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, double, float, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, double, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, double, long, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, double, long, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, double, long, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, double, long, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, double, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, double, double, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, double, double, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, double, double, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, double, double, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, double, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, double, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, double, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, double, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, double, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, int, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, int, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, int, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, int, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, float, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, float, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, float, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, float, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, long, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, long, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, long, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, long, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, double, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, double, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, double, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, double, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, int, int, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, int, int, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, int, int, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, int, int, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, int, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, int, float, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, int, float, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, int, float, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, int, float, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, int, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, int, long, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, int, long, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, int, long, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, int, long, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, int, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, int, double, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, int, double, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, int, double, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, int, double, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, int, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, int, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, int, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, int, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, int, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, float, int, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, float, int, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, float, int, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, float, int, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, float, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, float, float, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, float, float, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, float, float, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, float, float, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, float, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, float, long, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, float, long, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, float, long, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, float, long, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, float, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, float, double, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, float, double, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, float, double, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, float, double, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, float, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, float, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, float, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, float, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, float, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, long, int, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, long, int, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, long, int, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, long, int, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, long, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, long, float, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, long, float, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, long, float, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, long, float, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, long, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, long, double, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, long, double, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, long, double, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, long, double, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, long, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, long, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, long, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, long, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, long, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, double, int, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, double, int, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, double, int, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, double, int, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, double, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, double, float, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, double, float, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, double, float, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, double, float, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, double, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, double, long, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, double, long, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, double, long, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, double, long, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, double, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, double, double, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, double, double, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, double, double, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, double, double, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, double, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, double, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, double, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, double, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, double, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, int, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, int, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, int, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, int, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, float, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, float, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, float, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, float, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, long, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, long, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, long, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, long, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, double, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, double, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, double, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, double, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, int, int, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, int, int, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, int, int, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, int, int, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, int, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, int, float, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, int, float, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, int, float, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, int, float, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, int, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, int, long, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, int, long, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, int, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, int, long, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, int, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, int, double, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, int, double, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, int, double, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, int, double, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, int, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, int, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, int, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, int, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, int, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, float, int, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, float, int, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, float, int, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, float, int, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, float, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, float, float, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, float, float, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, float, float, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, float, float, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, float, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, float, long, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, float, long, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, float, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, float, long, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, float, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, float, double, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, float, double, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, float, double, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, float, double, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, float, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, float, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, float, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, float, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, float, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, long, int, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, long, int, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, long, int, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, long, int, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, long, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, long, float, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, long, float, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, long, float, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, long, float, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, long, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, long, double, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, long, double, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, long, double, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, long, double, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, long, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, long, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, long, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, long, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, long, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, double, int, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, double, int, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, double, int, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, double, int, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, double, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, double, float, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, double, float, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, double, float, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, double, float, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, double, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, double, long, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, double, long, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, double, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, double, long, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, double, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, double, double, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, double, double, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, double, double, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, double, double, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, double, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, double, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, double, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, double, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, double, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, int, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, int, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, int, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, int, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, float, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, float, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, float, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, float, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, long, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, long, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, long, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, double, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, double, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, double, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, double, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, int, int, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, int, int, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, int, int, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, int, int, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, int, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, int, float, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, int, float, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, int, float, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, int, float, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, int, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, int, long, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, int, long, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, int, long, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, int, long, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, int, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, int, double, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, int, double, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, int, double, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, int, double, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, int, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, int, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, int, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, int, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, int, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, float, int, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, float, int, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, float, int, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, float, int, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, float, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, float, float, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, float, float, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, float, float, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, float, float, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, float, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, float, long, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, float, long, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, float, long, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, float, long, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, float, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, float, double, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, float, double, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, float, double, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, float, double, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, float, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, float, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, float, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, float, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, float, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, long, int, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, long, int, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, long, int, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, long, int, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, long, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, long, float, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, long, float, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, long, float, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, long, float, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, long, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, long, double, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, long, double, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, long, double, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, long, double, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, long, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, long, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, long, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, long, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, long, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, double, int, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, double, int, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, double, int, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, double, int, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, double, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, double, float, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, double, float, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, double, float, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, double, float, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, double, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, double, long, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, double, long, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, double, long, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, double, long, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, double, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, double, double, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, double, double, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, double, double, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, double, double, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, double, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, double, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, double, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, double, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, double, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, int, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, int, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, int, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, int, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, float, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, float, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, float, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, float, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, long, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, long, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, long, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, long, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, double, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, double, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, double, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, double, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, int, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, int, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, int, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, int, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, float, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, float, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, float, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, float, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, long, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, long, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, long, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, long, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, double, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, double, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, double, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, double, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, int, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, int, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, int, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, int, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, float, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, float, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, float, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, float, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, long, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, long, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, long, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, long, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, double, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, double, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, double, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, double, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, int, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, int, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, int, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, int, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, float, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, float, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, float, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, float, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, double, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, double, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, double, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, double, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, int, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, int, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, int, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, int, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, float, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, float, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, float, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, float, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, long, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, long, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, long, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, long, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, double, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, double, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, double, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, double, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, int, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, int, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, int, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, int, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, float, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, float, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, float, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, float, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, long, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, long, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, long, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, long, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, double, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, double, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, double, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, double, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke33777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, int, int, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, int, int, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, int, int, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, int, int, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, int, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, int, float, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, int, float, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, int, float, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, int, float, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, int, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, int, long, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, int, long, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, int, long, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, int, long, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, int, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, int, double, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, int, double, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, int, double, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, int, double, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, int, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, int, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, int, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, int, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, int, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, float, int, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, float, int, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, float, int, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, float, int, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, float, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, float, float, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, float, float, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, float, float, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, float, float, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, float, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, float, long, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, float, long, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, float, long, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, float, long, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, float, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, float, double, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, float, double, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, float, double, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, float, double, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, float, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, float, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, float, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, float, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, float, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, long, int, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, long, int, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, long, int, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, long, int, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, long, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, long, float, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, long, float, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, long, float, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, long, float, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, long, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, long, long, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, long, long, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, long, long, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, long, long, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, long, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, long, double, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, long, double, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, long, double, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, long, double, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, long, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, long, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, long, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, long, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, long, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, double, int, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, double, int, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, double, int, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, double, int, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, double, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, double, float, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, double, float, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, double, float, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, double, float, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, double, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, double, long, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, double, long, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, double, long, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, double, long, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, double, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, double, double, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, double, double, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, double, double, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, double, double, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, double, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, double, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, double, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, double, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, double, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, int, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, int, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, int, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, int, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, float, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, float, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, float, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, float, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, long, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, long, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, long, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, long, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, double, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, double, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, double, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, double, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, int, int, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, int, int, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, int, int, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, int, int, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, int, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, int, float, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, int, float, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, int, float, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, int, float, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, int, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, int, long, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, int, long, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, int, long, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, int, long, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, int, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, int, double, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, int, double, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, int, double, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, int, double, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, int, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, int, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, int, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, int, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, int, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, float, int, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, float, int, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, float, int, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, float, int, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, float, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, float, float, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, float, float, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, float, float, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, float, float, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, float, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, float, long, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, float, long, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, float, long, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, float, long, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, float, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, float, double, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, float, double, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, float, double, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, float, double, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, float, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, float, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, float, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, float, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, float, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, long, int, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, long, int, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, long, int, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, long, int, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, long, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, long, float, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, long, float, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, long, float, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, long, float, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, long, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, long, long, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, long, long, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, long, long, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, long, long, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, long, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, long, double, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, long, double, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, long, double, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, long, double, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, long, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, long, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, long, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, long, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, long, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, double, int, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, double, int, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, double, int, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, double, int, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, double, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, double, float, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, double, float, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, double, float, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, double, float, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, double, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, double, long, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, double, long, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, double, long, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, double, long, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, double, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, double, double, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, double, double, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, double, double, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, double, double, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, double, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, double, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, double, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, double, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, double, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, int, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, int, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, int, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, int, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, float, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, float, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, float, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, float, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, long, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, long, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, long, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, long, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, double, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, double, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, double, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, double, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, int, int, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, int, int, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, int, int, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, int, int, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, int, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, int, float, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, int, float, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, int, float, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, int, float, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, int, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, int, long, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, int, long, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, int, long, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, int, long, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, int, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, int, double, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, int, double, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, int, double, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, int, double, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, int, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, int, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, int, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, int, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, int, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, float, int, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, float, int, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, float, int, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, float, int, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, float, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, float, float, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, float, float, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, float, float, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, float, float, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, float, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, float, long, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, float, long, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, float, long, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, float, long, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, float, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, float, double, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, float, double, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, float, double, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, float, double, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, float, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, float, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, float, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, float, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, float, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, long, int, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, long, int, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, long, int, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, long, int, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, long, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, long, float, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, long, float, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, long, float, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, long, float, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, long, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, long, long, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, long, long, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, long, long, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, long, long, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, long, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, long, double, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, long, double, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, long, double, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, long, double, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, long, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, long, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, long, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, long, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, long, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, double, int, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, double, int, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, double, int, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, double, int, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, double, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, double, float, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, double, float, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, double, float, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, double, float, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, double, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, double, long, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, double, long, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, double, long, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, double, long, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, double, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, double, double, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, double, double, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, double, double, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, double, double, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, double, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, double, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, double, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, double, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, double, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, int, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, int, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, int, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, int, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, float, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, float, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, float, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, float, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, long, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, long, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, long, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, long, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, double, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, double, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, double, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, double, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, int, int, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, int, int, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, int, int, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, int, int, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, int, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, int, float, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, int, float, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, int, float, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, int, float, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, int, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, int, long, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, int, long, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, int, long, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, int, long, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, int, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, int, double, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, int, double, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, int, double, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, int, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, int, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, int, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, int, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, int, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, int, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, float, int, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, float, int, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, float, int, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, float, int, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, float, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, float, float, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, float, float, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, float, float, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, float, float, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, float, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, float, long, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, float, long, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, float, long, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, float, long, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, float, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, float, double, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, float, double, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, float, double, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, float, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, float, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, float, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, float, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, float, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, float, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, long, int, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, long, int, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, long, int, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, long, int, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, long, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, long, float, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, long, float, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, long, float, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, long, float, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, long, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, long, long, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, long, long, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, long, long, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, long, long, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, long, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, long, double, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, long, double, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, long, double, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, long, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, long, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, long, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, long, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, long, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, long, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, double, int, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, double, int, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, double, int, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, double, int, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, double, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, double, float, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, double, float, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, double, float, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, double, float, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, double, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, double, long, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, double, long, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, double, long, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, double, long, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, double, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, double, double, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, double, double, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, double, double, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, double, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, double, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, double, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, double, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, double, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, double, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, int, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, int, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, int, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, int, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, float, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, float, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, float, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, float, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, long, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, long, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, long, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, long, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, double, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, double, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, double, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, int, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, int, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, int, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, int, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, float, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, float, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, float, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, float, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, long, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, long, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, long, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, long, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, double, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, double, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, double, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, double, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, int, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, int, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, int, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, int, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, float, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, float, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, float, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, float, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, long, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, long, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, long, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, long, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, double, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, double, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, double, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, double, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, int, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, int, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, int, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, int, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, float, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, float, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, float, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, float, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, long, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, long, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, long, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, long, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, double, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, double, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, double, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, double, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, int, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, int, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, int, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, int, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, float, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, float, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, float, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, float, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, long, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, long, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, long, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, long, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, double, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, double, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, double, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, double, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, int, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, int, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, int, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, int, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, float, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, float, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, float, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, float, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, long, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, long, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, long, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, long, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, double, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, double, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, double, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, double, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke35777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke37777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}
}
