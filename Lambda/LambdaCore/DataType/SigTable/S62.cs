using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S62
{
	public static int Invoke2(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke22XXXX(code, p, args), 
			'6' => Invoke26XXXX(code, p, args), 
			'3' => Invoke23XXXX(code, p, args), 
			'5' => Invoke25XXXX(code, p, args), 
			'7' => Invoke27XXXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke22XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke222XXX(code, p, args), 
			'6' => Invoke226XXX(code, p, args), 
			'3' => Invoke223XXX(code, p, args), 
			'5' => Invoke225XXX(code, p, args), 
			'7' => Invoke227XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke222XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2222XX(code, p, args), 
			'6' => Invoke2226XX(code, p, args), 
			'3' => Invoke2223XX(code, p, args), 
			'5' => Invoke2225XX(code, p, args), 
			'7' => Invoke2227XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2222XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22222X(code, p, args), 
			'6' => Invoke22226X(code, p, args), 
			'3' => Invoke22223X(code, p, args), 
			'5' => Invoke22225X(code, p, args), 
			'7' => Invoke22227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2226XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22262X(code, p, args), 
			'6' => Invoke22266X(code, p, args), 
			'3' => Invoke22263X(code, p, args), 
			'5' => Invoke22265X(code, p, args), 
			'7' => Invoke22267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2223XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22232X(code, p, args), 
			'6' => Invoke22236X(code, p, args), 
			'3' => Invoke22233X(code, p, args), 
			'5' => Invoke22235X(code, p, args), 
			'7' => Invoke22237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2225XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22252X(code, p, args), 
			'6' => Invoke22256X(code, p, args), 
			'3' => Invoke22253X(code, p, args), 
			'5' => Invoke22255X(code, p, args), 
			'7' => Invoke22257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2227XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22272X(code, p, args), 
			'6' => Invoke22276X(code, p, args), 
			'3' => Invoke22273X(code, p, args), 
			'5' => Invoke22275X(code, p, args), 
			'7' => Invoke22277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke226XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2262XX(code, p, args), 
			'6' => Invoke2266XX(code, p, args), 
			'3' => Invoke2263XX(code, p, args), 
			'5' => Invoke2265XX(code, p, args), 
			'7' => Invoke2267XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2262XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22622X(code, p, args), 
			'6' => Invoke22626X(code, p, args), 
			'3' => Invoke22623X(code, p, args), 
			'5' => Invoke22625X(code, p, args), 
			'7' => Invoke22627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2266XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22662X(code, p, args), 
			'6' => Invoke22666X(code, p, args), 
			'3' => Invoke22663X(code, p, args), 
			'5' => Invoke22665X(code, p, args), 
			'7' => Invoke22667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2263XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22632X(code, p, args), 
			'6' => Invoke22636X(code, p, args), 
			'3' => Invoke22633X(code, p, args), 
			'5' => Invoke22635X(code, p, args), 
			'7' => Invoke22637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2265XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22652X(code, p, args), 
			'6' => Invoke22656X(code, p, args), 
			'3' => Invoke22653X(code, p, args), 
			'5' => Invoke22655X(code, p, args), 
			'7' => Invoke22657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2267XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22672X(code, p, args), 
			'6' => Invoke22676X(code, p, args), 
			'3' => Invoke22673X(code, p, args), 
			'5' => Invoke22675X(code, p, args), 
			'7' => Invoke22677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke223XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2232XX(code, p, args), 
			'6' => Invoke2236XX(code, p, args), 
			'3' => Invoke2233XX(code, p, args), 
			'5' => Invoke2235XX(code, p, args), 
			'7' => Invoke2237XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2232XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22322X(code, p, args), 
			'6' => Invoke22326X(code, p, args), 
			'3' => Invoke22323X(code, p, args), 
			'5' => Invoke22325X(code, p, args), 
			'7' => Invoke22327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2236XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22362X(code, p, args), 
			'6' => Invoke22366X(code, p, args), 
			'3' => Invoke22363X(code, p, args), 
			'5' => Invoke22365X(code, p, args), 
			'7' => Invoke22367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2233XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22332X(code, p, args), 
			'6' => Invoke22336X(code, p, args), 
			'3' => Invoke22333X(code, p, args), 
			'5' => Invoke22335X(code, p, args), 
			'7' => Invoke22337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2235XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22352X(code, p, args), 
			'6' => Invoke22356X(code, p, args), 
			'3' => Invoke22353X(code, p, args), 
			'5' => Invoke22355X(code, p, args), 
			'7' => Invoke22357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2237XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22372X(code, p, args), 
			'6' => Invoke22376X(code, p, args), 
			'3' => Invoke22373X(code, p, args), 
			'5' => Invoke22375X(code, p, args), 
			'7' => Invoke22377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke225XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2252XX(code, p, args), 
			'6' => Invoke2256XX(code, p, args), 
			'3' => Invoke2253XX(code, p, args), 
			'5' => Invoke2255XX(code, p, args), 
			'7' => Invoke2257XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2252XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22522X(code, p, args), 
			'6' => Invoke22526X(code, p, args), 
			'3' => Invoke22523X(code, p, args), 
			'5' => Invoke22525X(code, p, args), 
			'7' => Invoke22527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2256XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22562X(code, p, args), 
			'6' => Invoke22566X(code, p, args), 
			'3' => Invoke22563X(code, p, args), 
			'5' => Invoke22565X(code, p, args), 
			'7' => Invoke22567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2253XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22532X(code, p, args), 
			'6' => Invoke22536X(code, p, args), 
			'3' => Invoke22533X(code, p, args), 
			'5' => Invoke22535X(code, p, args), 
			'7' => Invoke22537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2255XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22552X(code, p, args), 
			'6' => Invoke22556X(code, p, args), 
			'3' => Invoke22553X(code, p, args), 
			'5' => Invoke22555X(code, p, args), 
			'7' => Invoke22557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2257XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22572X(code, p, args), 
			'6' => Invoke22576X(code, p, args), 
			'3' => Invoke22573X(code, p, args), 
			'5' => Invoke22575X(code, p, args), 
			'7' => Invoke22577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke227XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2272XX(code, p, args), 
			'6' => Invoke2276XX(code, p, args), 
			'3' => Invoke2273XX(code, p, args), 
			'5' => Invoke2275XX(code, p, args), 
			'7' => Invoke2277XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2272XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22722X(code, p, args), 
			'6' => Invoke22726X(code, p, args), 
			'3' => Invoke22723X(code, p, args), 
			'5' => Invoke22725X(code, p, args), 
			'7' => Invoke22727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2276XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22762X(code, p, args), 
			'6' => Invoke22766X(code, p, args), 
			'3' => Invoke22763X(code, p, args), 
			'5' => Invoke22765X(code, p, args), 
			'7' => Invoke22767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2273XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22732X(code, p, args), 
			'6' => Invoke22736X(code, p, args), 
			'3' => Invoke22733X(code, p, args), 
			'5' => Invoke22735X(code, p, args), 
			'7' => Invoke22737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2275XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22752X(code, p, args), 
			'6' => Invoke22756X(code, p, args), 
			'3' => Invoke22753X(code, p, args), 
			'5' => Invoke22755X(code, p, args), 
			'7' => Invoke22757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2277XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke22772X(code, p, args), 
			'6' => Invoke22776X(code, p, args), 
			'3' => Invoke22773X(code, p, args), 
			'5' => Invoke22775X(code, p, args), 
			'7' => Invoke22777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke26XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke262XXX(code, p, args), 
			'6' => Invoke266XXX(code, p, args), 
			'3' => Invoke263XXX(code, p, args), 
			'5' => Invoke265XXX(code, p, args), 
			'7' => Invoke267XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke262XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2622XX(code, p, args), 
			'6' => Invoke2626XX(code, p, args), 
			'3' => Invoke2623XX(code, p, args), 
			'5' => Invoke2625XX(code, p, args), 
			'7' => Invoke2627XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2622XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26222X(code, p, args), 
			'6' => Invoke26226X(code, p, args), 
			'3' => Invoke26223X(code, p, args), 
			'5' => Invoke26225X(code, p, args), 
			'7' => Invoke26227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2626XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26262X(code, p, args), 
			'6' => Invoke26266X(code, p, args), 
			'3' => Invoke26263X(code, p, args), 
			'5' => Invoke26265X(code, p, args), 
			'7' => Invoke26267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2623XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26232X(code, p, args), 
			'6' => Invoke26236X(code, p, args), 
			'3' => Invoke26233X(code, p, args), 
			'5' => Invoke26235X(code, p, args), 
			'7' => Invoke26237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2625XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26252X(code, p, args), 
			'6' => Invoke26256X(code, p, args), 
			'3' => Invoke26253X(code, p, args), 
			'5' => Invoke26255X(code, p, args), 
			'7' => Invoke26257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2627XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26272X(code, p, args), 
			'6' => Invoke26276X(code, p, args), 
			'3' => Invoke26273X(code, p, args), 
			'5' => Invoke26275X(code, p, args), 
			'7' => Invoke26277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke266XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2662XX(code, p, args), 
			'6' => Invoke2666XX(code, p, args), 
			'3' => Invoke2663XX(code, p, args), 
			'5' => Invoke2665XX(code, p, args), 
			'7' => Invoke2667XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2662XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26622X(code, p, args), 
			'6' => Invoke26626X(code, p, args), 
			'3' => Invoke26623X(code, p, args), 
			'5' => Invoke26625X(code, p, args), 
			'7' => Invoke26627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2666XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26662X(code, p, args), 
			'6' => Invoke26666X(code, p, args), 
			'3' => Invoke26663X(code, p, args), 
			'5' => Invoke26665X(code, p, args), 
			'7' => Invoke26667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2663XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26632X(code, p, args), 
			'6' => Invoke26636X(code, p, args), 
			'3' => Invoke26633X(code, p, args), 
			'5' => Invoke26635X(code, p, args), 
			'7' => Invoke26637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2665XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26652X(code, p, args), 
			'6' => Invoke26656X(code, p, args), 
			'3' => Invoke26653X(code, p, args), 
			'5' => Invoke26655X(code, p, args), 
			'7' => Invoke26657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2667XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26672X(code, p, args), 
			'6' => Invoke26676X(code, p, args), 
			'3' => Invoke26673X(code, p, args), 
			'5' => Invoke26675X(code, p, args), 
			'7' => Invoke26677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke263XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2632XX(code, p, args), 
			'6' => Invoke2636XX(code, p, args), 
			'3' => Invoke2633XX(code, p, args), 
			'5' => Invoke2635XX(code, p, args), 
			'7' => Invoke2637XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2632XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26322X(code, p, args), 
			'6' => Invoke26326X(code, p, args), 
			'3' => Invoke26323X(code, p, args), 
			'5' => Invoke26325X(code, p, args), 
			'7' => Invoke26327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2636XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26362X(code, p, args), 
			'6' => Invoke26366X(code, p, args), 
			'3' => Invoke26363X(code, p, args), 
			'5' => Invoke26365X(code, p, args), 
			'7' => Invoke26367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2633XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26332X(code, p, args), 
			'6' => Invoke26336X(code, p, args), 
			'3' => Invoke26333X(code, p, args), 
			'5' => Invoke26335X(code, p, args), 
			'7' => Invoke26337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2635XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26352X(code, p, args), 
			'6' => Invoke26356X(code, p, args), 
			'3' => Invoke26353X(code, p, args), 
			'5' => Invoke26355X(code, p, args), 
			'7' => Invoke26357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2637XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26372X(code, p, args), 
			'6' => Invoke26376X(code, p, args), 
			'3' => Invoke26373X(code, p, args), 
			'5' => Invoke26375X(code, p, args), 
			'7' => Invoke26377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke265XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2652XX(code, p, args), 
			'6' => Invoke2656XX(code, p, args), 
			'3' => Invoke2653XX(code, p, args), 
			'5' => Invoke2655XX(code, p, args), 
			'7' => Invoke2657XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2652XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26522X(code, p, args), 
			'6' => Invoke26526X(code, p, args), 
			'3' => Invoke26523X(code, p, args), 
			'5' => Invoke26525X(code, p, args), 
			'7' => Invoke26527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2656XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26562X(code, p, args), 
			'6' => Invoke26566X(code, p, args), 
			'3' => Invoke26563X(code, p, args), 
			'5' => Invoke26565X(code, p, args), 
			'7' => Invoke26567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2653XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26532X(code, p, args), 
			'6' => Invoke26536X(code, p, args), 
			'3' => Invoke26533X(code, p, args), 
			'5' => Invoke26535X(code, p, args), 
			'7' => Invoke26537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2655XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26552X(code, p, args), 
			'6' => Invoke26556X(code, p, args), 
			'3' => Invoke26553X(code, p, args), 
			'5' => Invoke26555X(code, p, args), 
			'7' => Invoke26557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2657XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26572X(code, p, args), 
			'6' => Invoke26576X(code, p, args), 
			'3' => Invoke26573X(code, p, args), 
			'5' => Invoke26575X(code, p, args), 
			'7' => Invoke26577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke267XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2672XX(code, p, args), 
			'6' => Invoke2676XX(code, p, args), 
			'3' => Invoke2673XX(code, p, args), 
			'5' => Invoke2675XX(code, p, args), 
			'7' => Invoke2677XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2672XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26722X(code, p, args), 
			'6' => Invoke26726X(code, p, args), 
			'3' => Invoke26723X(code, p, args), 
			'5' => Invoke26725X(code, p, args), 
			'7' => Invoke26727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2676XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26762X(code, p, args), 
			'6' => Invoke26766X(code, p, args), 
			'3' => Invoke26763X(code, p, args), 
			'5' => Invoke26765X(code, p, args), 
			'7' => Invoke26767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2673XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26732X(code, p, args), 
			'6' => Invoke26736X(code, p, args), 
			'3' => Invoke26733X(code, p, args), 
			'5' => Invoke26735X(code, p, args), 
			'7' => Invoke26737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2675XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26752X(code, p, args), 
			'6' => Invoke26756X(code, p, args), 
			'3' => Invoke26753X(code, p, args), 
			'5' => Invoke26755X(code, p, args), 
			'7' => Invoke26757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2677XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke26772X(code, p, args), 
			'6' => Invoke26776X(code, p, args), 
			'3' => Invoke26773X(code, p, args), 
			'5' => Invoke26775X(code, p, args), 
			'7' => Invoke26777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke23XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke232XXX(code, p, args), 
			'6' => Invoke236XXX(code, p, args), 
			'3' => Invoke233XXX(code, p, args), 
			'5' => Invoke235XXX(code, p, args), 
			'7' => Invoke237XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke232XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2322XX(code, p, args), 
			'6' => Invoke2326XX(code, p, args), 
			'3' => Invoke2323XX(code, p, args), 
			'5' => Invoke2325XX(code, p, args), 
			'7' => Invoke2327XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2322XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23222X(code, p, args), 
			'6' => Invoke23226X(code, p, args), 
			'3' => Invoke23223X(code, p, args), 
			'5' => Invoke23225X(code, p, args), 
			'7' => Invoke23227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2326XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23262X(code, p, args), 
			'6' => Invoke23266X(code, p, args), 
			'3' => Invoke23263X(code, p, args), 
			'5' => Invoke23265X(code, p, args), 
			'7' => Invoke23267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2323XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23232X(code, p, args), 
			'6' => Invoke23236X(code, p, args), 
			'3' => Invoke23233X(code, p, args), 
			'5' => Invoke23235X(code, p, args), 
			'7' => Invoke23237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2325XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23252X(code, p, args), 
			'6' => Invoke23256X(code, p, args), 
			'3' => Invoke23253X(code, p, args), 
			'5' => Invoke23255X(code, p, args), 
			'7' => Invoke23257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2327XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23272X(code, p, args), 
			'6' => Invoke23276X(code, p, args), 
			'3' => Invoke23273X(code, p, args), 
			'5' => Invoke23275X(code, p, args), 
			'7' => Invoke23277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke236XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2362XX(code, p, args), 
			'6' => Invoke2366XX(code, p, args), 
			'3' => Invoke2363XX(code, p, args), 
			'5' => Invoke2365XX(code, p, args), 
			'7' => Invoke2367XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2362XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23622X(code, p, args), 
			'6' => Invoke23626X(code, p, args), 
			'3' => Invoke23623X(code, p, args), 
			'5' => Invoke23625X(code, p, args), 
			'7' => Invoke23627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2366XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23662X(code, p, args), 
			'6' => Invoke23666X(code, p, args), 
			'3' => Invoke23663X(code, p, args), 
			'5' => Invoke23665X(code, p, args), 
			'7' => Invoke23667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2363XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23632X(code, p, args), 
			'6' => Invoke23636X(code, p, args), 
			'3' => Invoke23633X(code, p, args), 
			'5' => Invoke23635X(code, p, args), 
			'7' => Invoke23637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2365XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23652X(code, p, args), 
			'6' => Invoke23656X(code, p, args), 
			'3' => Invoke23653X(code, p, args), 
			'5' => Invoke23655X(code, p, args), 
			'7' => Invoke23657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2367XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23672X(code, p, args), 
			'6' => Invoke23676X(code, p, args), 
			'3' => Invoke23673X(code, p, args), 
			'5' => Invoke23675X(code, p, args), 
			'7' => Invoke23677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke233XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2332XX(code, p, args), 
			'6' => Invoke2336XX(code, p, args), 
			'3' => Invoke2333XX(code, p, args), 
			'5' => Invoke2335XX(code, p, args), 
			'7' => Invoke2337XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2332XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23322X(code, p, args), 
			'6' => Invoke23326X(code, p, args), 
			'3' => Invoke23323X(code, p, args), 
			'5' => Invoke23325X(code, p, args), 
			'7' => Invoke23327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2336XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23362X(code, p, args), 
			'6' => Invoke23366X(code, p, args), 
			'3' => Invoke23363X(code, p, args), 
			'5' => Invoke23365X(code, p, args), 
			'7' => Invoke23367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2333XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23332X(code, p, args), 
			'6' => Invoke23336X(code, p, args), 
			'3' => Invoke23333X(code, p, args), 
			'5' => Invoke23335X(code, p, args), 
			'7' => Invoke23337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2335XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23352X(code, p, args), 
			'6' => Invoke23356X(code, p, args), 
			'3' => Invoke23353X(code, p, args), 
			'5' => Invoke23355X(code, p, args), 
			'7' => Invoke23357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2337XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23372X(code, p, args), 
			'6' => Invoke23376X(code, p, args), 
			'3' => Invoke23373X(code, p, args), 
			'5' => Invoke23375X(code, p, args), 
			'7' => Invoke23377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke235XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2352XX(code, p, args), 
			'6' => Invoke2356XX(code, p, args), 
			'3' => Invoke2353XX(code, p, args), 
			'5' => Invoke2355XX(code, p, args), 
			'7' => Invoke2357XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2352XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23522X(code, p, args), 
			'6' => Invoke23526X(code, p, args), 
			'3' => Invoke23523X(code, p, args), 
			'5' => Invoke23525X(code, p, args), 
			'7' => Invoke23527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2356XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23562X(code, p, args), 
			'6' => Invoke23566X(code, p, args), 
			'3' => Invoke23563X(code, p, args), 
			'5' => Invoke23565X(code, p, args), 
			'7' => Invoke23567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2353XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23532X(code, p, args), 
			'6' => Invoke23536X(code, p, args), 
			'3' => Invoke23533X(code, p, args), 
			'5' => Invoke23535X(code, p, args), 
			'7' => Invoke23537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2355XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23552X(code, p, args), 
			'6' => Invoke23556X(code, p, args), 
			'3' => Invoke23553X(code, p, args), 
			'5' => Invoke23555X(code, p, args), 
			'7' => Invoke23557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2357XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23572X(code, p, args), 
			'6' => Invoke23576X(code, p, args), 
			'3' => Invoke23573X(code, p, args), 
			'5' => Invoke23575X(code, p, args), 
			'7' => Invoke23577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke237XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2372XX(code, p, args), 
			'6' => Invoke2376XX(code, p, args), 
			'3' => Invoke2373XX(code, p, args), 
			'5' => Invoke2375XX(code, p, args), 
			'7' => Invoke2377XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2372XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23722X(code, p, args), 
			'6' => Invoke23726X(code, p, args), 
			'3' => Invoke23723X(code, p, args), 
			'5' => Invoke23725X(code, p, args), 
			'7' => Invoke23727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2376XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23762X(code, p, args), 
			'6' => Invoke23766X(code, p, args), 
			'3' => Invoke23763X(code, p, args), 
			'5' => Invoke23765X(code, p, args), 
			'7' => Invoke23767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2373XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23732X(code, p, args), 
			'6' => Invoke23736X(code, p, args), 
			'3' => Invoke23733X(code, p, args), 
			'5' => Invoke23735X(code, p, args), 
			'7' => Invoke23737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2375XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23752X(code, p, args), 
			'6' => Invoke23756X(code, p, args), 
			'3' => Invoke23753X(code, p, args), 
			'5' => Invoke23755X(code, p, args), 
			'7' => Invoke23757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2377XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke23772X(code, p, args), 
			'6' => Invoke23776X(code, p, args), 
			'3' => Invoke23773X(code, p, args), 
			'5' => Invoke23775X(code, p, args), 
			'7' => Invoke23777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke25XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke252XXX(code, p, args), 
			'6' => Invoke256XXX(code, p, args), 
			'3' => Invoke253XXX(code, p, args), 
			'5' => Invoke255XXX(code, p, args), 
			'7' => Invoke257XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke252XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2522XX(code, p, args), 
			'6' => Invoke2526XX(code, p, args), 
			'3' => Invoke2523XX(code, p, args), 
			'5' => Invoke2525XX(code, p, args), 
			'7' => Invoke2527XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2522XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25222X(code, p, args), 
			'6' => Invoke25226X(code, p, args), 
			'3' => Invoke25223X(code, p, args), 
			'5' => Invoke25225X(code, p, args), 
			'7' => Invoke25227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2526XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25262X(code, p, args), 
			'6' => Invoke25266X(code, p, args), 
			'3' => Invoke25263X(code, p, args), 
			'5' => Invoke25265X(code, p, args), 
			'7' => Invoke25267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2523XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25232X(code, p, args), 
			'6' => Invoke25236X(code, p, args), 
			'3' => Invoke25233X(code, p, args), 
			'5' => Invoke25235X(code, p, args), 
			'7' => Invoke25237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2525XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25252X(code, p, args), 
			'6' => Invoke25256X(code, p, args), 
			'3' => Invoke25253X(code, p, args), 
			'5' => Invoke25255X(code, p, args), 
			'7' => Invoke25257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2527XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25272X(code, p, args), 
			'6' => Invoke25276X(code, p, args), 
			'3' => Invoke25273X(code, p, args), 
			'5' => Invoke25275X(code, p, args), 
			'7' => Invoke25277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke256XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2562XX(code, p, args), 
			'6' => Invoke2566XX(code, p, args), 
			'3' => Invoke2563XX(code, p, args), 
			'5' => Invoke2565XX(code, p, args), 
			'7' => Invoke2567XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2562XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25622X(code, p, args), 
			'6' => Invoke25626X(code, p, args), 
			'3' => Invoke25623X(code, p, args), 
			'5' => Invoke25625X(code, p, args), 
			'7' => Invoke25627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2566XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25662X(code, p, args), 
			'6' => Invoke25666X(code, p, args), 
			'3' => Invoke25663X(code, p, args), 
			'5' => Invoke25665X(code, p, args), 
			'7' => Invoke25667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2563XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25632X(code, p, args), 
			'6' => Invoke25636X(code, p, args), 
			'3' => Invoke25633X(code, p, args), 
			'5' => Invoke25635X(code, p, args), 
			'7' => Invoke25637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2565XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25652X(code, p, args), 
			'6' => Invoke25656X(code, p, args), 
			'3' => Invoke25653X(code, p, args), 
			'5' => Invoke25655X(code, p, args), 
			'7' => Invoke25657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2567XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25672X(code, p, args), 
			'6' => Invoke25676X(code, p, args), 
			'3' => Invoke25673X(code, p, args), 
			'5' => Invoke25675X(code, p, args), 
			'7' => Invoke25677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke253XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2532XX(code, p, args), 
			'6' => Invoke2536XX(code, p, args), 
			'3' => Invoke2533XX(code, p, args), 
			'5' => Invoke2535XX(code, p, args), 
			'7' => Invoke2537XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2532XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25322X(code, p, args), 
			'6' => Invoke25326X(code, p, args), 
			'3' => Invoke25323X(code, p, args), 
			'5' => Invoke25325X(code, p, args), 
			'7' => Invoke25327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2536XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25362X(code, p, args), 
			'6' => Invoke25366X(code, p, args), 
			'3' => Invoke25363X(code, p, args), 
			'5' => Invoke25365X(code, p, args), 
			'7' => Invoke25367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2533XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25332X(code, p, args), 
			'6' => Invoke25336X(code, p, args), 
			'3' => Invoke25333X(code, p, args), 
			'5' => Invoke25335X(code, p, args), 
			'7' => Invoke25337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2535XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25352X(code, p, args), 
			'6' => Invoke25356X(code, p, args), 
			'3' => Invoke25353X(code, p, args), 
			'5' => Invoke25355X(code, p, args), 
			'7' => Invoke25357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2537XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25372X(code, p, args), 
			'6' => Invoke25376X(code, p, args), 
			'3' => Invoke25373X(code, p, args), 
			'5' => Invoke25375X(code, p, args), 
			'7' => Invoke25377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke255XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2552XX(code, p, args), 
			'6' => Invoke2556XX(code, p, args), 
			'3' => Invoke2553XX(code, p, args), 
			'5' => Invoke2555XX(code, p, args), 
			'7' => Invoke2557XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2552XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25522X(code, p, args), 
			'6' => Invoke25526X(code, p, args), 
			'3' => Invoke25523X(code, p, args), 
			'5' => Invoke25525X(code, p, args), 
			'7' => Invoke25527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2556XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25562X(code, p, args), 
			'6' => Invoke25566X(code, p, args), 
			'3' => Invoke25563X(code, p, args), 
			'5' => Invoke25565X(code, p, args), 
			'7' => Invoke25567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2553XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25532X(code, p, args), 
			'6' => Invoke25536X(code, p, args), 
			'3' => Invoke25533X(code, p, args), 
			'5' => Invoke25535X(code, p, args), 
			'7' => Invoke25537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2555XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25552X(code, p, args), 
			'6' => Invoke25556X(code, p, args), 
			'3' => Invoke25553X(code, p, args), 
			'5' => Invoke25555X(code, p, args), 
			'7' => Invoke25557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2557XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25572X(code, p, args), 
			'6' => Invoke25576X(code, p, args), 
			'3' => Invoke25573X(code, p, args), 
			'5' => Invoke25575X(code, p, args), 
			'7' => Invoke25577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke257XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2572XX(code, p, args), 
			'6' => Invoke2576XX(code, p, args), 
			'3' => Invoke2573XX(code, p, args), 
			'5' => Invoke2575XX(code, p, args), 
			'7' => Invoke2577XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2572XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25722X(code, p, args), 
			'6' => Invoke25726X(code, p, args), 
			'3' => Invoke25723X(code, p, args), 
			'5' => Invoke25725X(code, p, args), 
			'7' => Invoke25727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2576XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25762X(code, p, args), 
			'6' => Invoke25766X(code, p, args), 
			'3' => Invoke25763X(code, p, args), 
			'5' => Invoke25765X(code, p, args), 
			'7' => Invoke25767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2573XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25732X(code, p, args), 
			'6' => Invoke25736X(code, p, args), 
			'3' => Invoke25733X(code, p, args), 
			'5' => Invoke25735X(code, p, args), 
			'7' => Invoke25737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2575XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25752X(code, p, args), 
			'6' => Invoke25756X(code, p, args), 
			'3' => Invoke25753X(code, p, args), 
			'5' => Invoke25755X(code, p, args), 
			'7' => Invoke25757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2577XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke25772X(code, p, args), 
			'6' => Invoke25776X(code, p, args), 
			'3' => Invoke25773X(code, p, args), 
			'5' => Invoke25775X(code, p, args), 
			'7' => Invoke25777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke27XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke272XXX(code, p, args), 
			'6' => Invoke276XXX(code, p, args), 
			'3' => Invoke273XXX(code, p, args), 
			'5' => Invoke275XXX(code, p, args), 
			'7' => Invoke277XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke272XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2722XX(code, p, args), 
			'6' => Invoke2726XX(code, p, args), 
			'3' => Invoke2723XX(code, p, args), 
			'5' => Invoke2725XX(code, p, args), 
			'7' => Invoke2727XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2722XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27222X(code, p, args), 
			'6' => Invoke27226X(code, p, args), 
			'3' => Invoke27223X(code, p, args), 
			'5' => Invoke27225X(code, p, args), 
			'7' => Invoke27227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2726XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27262X(code, p, args), 
			'6' => Invoke27266X(code, p, args), 
			'3' => Invoke27263X(code, p, args), 
			'5' => Invoke27265X(code, p, args), 
			'7' => Invoke27267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2723XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27232X(code, p, args), 
			'6' => Invoke27236X(code, p, args), 
			'3' => Invoke27233X(code, p, args), 
			'5' => Invoke27235X(code, p, args), 
			'7' => Invoke27237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2725XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27252X(code, p, args), 
			'6' => Invoke27256X(code, p, args), 
			'3' => Invoke27253X(code, p, args), 
			'5' => Invoke27255X(code, p, args), 
			'7' => Invoke27257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2727XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27272X(code, p, args), 
			'6' => Invoke27276X(code, p, args), 
			'3' => Invoke27273X(code, p, args), 
			'5' => Invoke27275X(code, p, args), 
			'7' => Invoke27277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke276XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2762XX(code, p, args), 
			'6' => Invoke2766XX(code, p, args), 
			'3' => Invoke2763XX(code, p, args), 
			'5' => Invoke2765XX(code, p, args), 
			'7' => Invoke2767XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2762XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27622X(code, p, args), 
			'6' => Invoke27626X(code, p, args), 
			'3' => Invoke27623X(code, p, args), 
			'5' => Invoke27625X(code, p, args), 
			'7' => Invoke27627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2766XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27662X(code, p, args), 
			'6' => Invoke27666X(code, p, args), 
			'3' => Invoke27663X(code, p, args), 
			'5' => Invoke27665X(code, p, args), 
			'7' => Invoke27667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2763XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27632X(code, p, args), 
			'6' => Invoke27636X(code, p, args), 
			'3' => Invoke27633X(code, p, args), 
			'5' => Invoke27635X(code, p, args), 
			'7' => Invoke27637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2765XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27652X(code, p, args), 
			'6' => Invoke27656X(code, p, args), 
			'3' => Invoke27653X(code, p, args), 
			'5' => Invoke27655X(code, p, args), 
			'7' => Invoke27657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2767XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27672X(code, p, args), 
			'6' => Invoke27676X(code, p, args), 
			'3' => Invoke27673X(code, p, args), 
			'5' => Invoke27675X(code, p, args), 
			'7' => Invoke27677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke273XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2732XX(code, p, args), 
			'6' => Invoke2736XX(code, p, args), 
			'3' => Invoke2733XX(code, p, args), 
			'5' => Invoke2735XX(code, p, args), 
			'7' => Invoke2737XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2732XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27322X(code, p, args), 
			'6' => Invoke27326X(code, p, args), 
			'3' => Invoke27323X(code, p, args), 
			'5' => Invoke27325X(code, p, args), 
			'7' => Invoke27327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2736XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27362X(code, p, args), 
			'6' => Invoke27366X(code, p, args), 
			'3' => Invoke27363X(code, p, args), 
			'5' => Invoke27365X(code, p, args), 
			'7' => Invoke27367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2733XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27332X(code, p, args), 
			'6' => Invoke27336X(code, p, args), 
			'3' => Invoke27333X(code, p, args), 
			'5' => Invoke27335X(code, p, args), 
			'7' => Invoke27337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2735XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27352X(code, p, args), 
			'6' => Invoke27356X(code, p, args), 
			'3' => Invoke27353X(code, p, args), 
			'5' => Invoke27355X(code, p, args), 
			'7' => Invoke27357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2737XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27372X(code, p, args), 
			'6' => Invoke27376X(code, p, args), 
			'3' => Invoke27373X(code, p, args), 
			'5' => Invoke27375X(code, p, args), 
			'7' => Invoke27377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke275XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2752XX(code, p, args), 
			'6' => Invoke2756XX(code, p, args), 
			'3' => Invoke2753XX(code, p, args), 
			'5' => Invoke2755XX(code, p, args), 
			'7' => Invoke2757XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2752XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27522X(code, p, args), 
			'6' => Invoke27526X(code, p, args), 
			'3' => Invoke27523X(code, p, args), 
			'5' => Invoke27525X(code, p, args), 
			'7' => Invoke27527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2756XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27562X(code, p, args), 
			'6' => Invoke27566X(code, p, args), 
			'3' => Invoke27563X(code, p, args), 
			'5' => Invoke27565X(code, p, args), 
			'7' => Invoke27567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2753XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27532X(code, p, args), 
			'6' => Invoke27536X(code, p, args), 
			'3' => Invoke27533X(code, p, args), 
			'5' => Invoke27535X(code, p, args), 
			'7' => Invoke27537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2755XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27552X(code, p, args), 
			'6' => Invoke27556X(code, p, args), 
			'3' => Invoke27553X(code, p, args), 
			'5' => Invoke27555X(code, p, args), 
			'7' => Invoke27557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2757XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27572X(code, p, args), 
			'6' => Invoke27576X(code, p, args), 
			'3' => Invoke27573X(code, p, args), 
			'5' => Invoke27575X(code, p, args), 
			'7' => Invoke27577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke277XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2772XX(code, p, args), 
			'6' => Invoke2776XX(code, p, args), 
			'3' => Invoke2773XX(code, p, args), 
			'5' => Invoke2775XX(code, p, args), 
			'7' => Invoke2777XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2772XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27722X(code, p, args), 
			'6' => Invoke27726X(code, p, args), 
			'3' => Invoke27723X(code, p, args), 
			'5' => Invoke27725X(code, p, args), 
			'7' => Invoke27727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2776XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27762X(code, p, args), 
			'6' => Invoke27766X(code, p, args), 
			'3' => Invoke27763X(code, p, args), 
			'5' => Invoke27765X(code, p, args), 
			'7' => Invoke27767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2773XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27732X(code, p, args), 
			'6' => Invoke27736X(code, p, args), 
			'3' => Invoke27733X(code, p, args), 
			'5' => Invoke27735X(code, p, args), 
			'7' => Invoke27737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2775XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27752X(code, p, args), 
			'6' => Invoke27756X(code, p, args), 
			'3' => Invoke27753X(code, p, args), 
			'5' => Invoke27755X(code, p, args), 
			'7' => Invoke27757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2777XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke27772X(code, p, args), 
			'6' => Invoke27776X(code, p, args), 
			'3' => Invoke27773X(code, p, args), 
			'5' => Invoke27775X(code, p, args), 
			'7' => Invoke27777X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, int, float, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, int, float, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, int, float, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, int, float, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, int, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, int, long, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, int, long, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, int, long, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, int, long, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, int, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, int, double, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, int, double, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, int, double, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, int, double, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, int, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, float, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, float, int, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, float, int, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, float, int, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, float, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, float, float, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, float, float, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, float, float, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, float, float, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, float, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, float, long, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, float, long, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, float, long, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, float, long, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, float, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, float, double, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, float, double, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, float, double, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, float, double, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, float, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, float, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, float, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, float, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, float, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, long, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, long, int, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, long, int, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, long, int, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, long, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, long, float, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, long, float, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, long, float, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, long, float, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, long, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, long, long, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, long, long, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, long, long, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, long, long, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, long, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, long, double, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, long, double, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, long, double, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, long, double, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, long, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, long, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, long, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, long, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, long, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, double, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, double, int, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, double, int, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, double, int, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, double, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, double, float, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, double, float, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, double, float, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, double, float, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, double, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, double, long, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, double, long, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, double, long, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, double, long, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, double, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, double, double, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, double, double, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, double, double, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, double, double, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, double, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, double, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, double, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, double, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, double, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, int, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, int, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, int, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, float, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, float, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, float, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, float, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, long, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, long, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, long, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, long, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, double, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, double, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, double, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, double, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, int, float, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, int, float, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, int, float, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, int, float, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, int, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, int, long, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, int, long, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, int, long, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, int, long, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, int, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, int, double, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, int, double, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, int, double, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, int, double, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, int, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, int, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, int, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, int, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, int, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, float, int, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, float, int, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, float, int, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, float, int, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, float, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, float, float, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, float, float, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, float, float, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, float, float, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, float, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, float, long, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, float, long, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, float, long, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, float, long, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, float, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, float, double, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, float, double, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, float, double, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, float, double, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, float, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, float, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, float, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, float, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, float, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, long, int, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, long, int, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, long, int, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, long, int, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, long, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, long, float, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, long, float, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, long, float, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, long, float, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, long, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, long, long, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, long, long, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, long, long, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, long, long, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, long, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, long, double, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, long, double, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, long, double, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, long, double, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, long, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, long, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, long, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, long, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, long, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, double, int, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, double, int, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, double, int, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, double, int, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, double, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, double, float, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, double, float, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, double, float, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, double, float, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, double, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, double, long, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, double, long, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, double, long, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, double, long, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, double, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, double, double, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, double, double, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, double, double, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, double, double, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, double, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, double, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, double, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, double, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, double, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, int, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, int, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, int, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, int, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, float, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, float, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, float, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, float, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, long, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, long, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, long, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, long, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, double, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, double, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, double, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, double, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, int, float, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, int, float, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, int, float, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, int, float, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, int, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, int, long, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, int, long, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, int, long, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, int, long, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, int, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, int, double, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, int, double, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, int, double, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, int, double, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, int, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, int, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, int, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, int, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, int, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, float, int, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, float, int, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, float, int, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, float, int, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, float, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, float, float, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, float, float, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, float, float, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, float, float, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, float, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, float, long, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, float, long, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, float, long, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, float, long, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, float, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, float, double, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, float, double, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, float, double, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, float, double, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, float, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, float, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, float, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, float, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, float, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, long, int, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, long, int, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, long, int, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, long, int, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, long, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, long, float, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, long, float, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, long, float, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, long, float, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, long, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, long, long, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, long, long, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, long, long, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, long, long, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, long, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, long, double, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, long, double, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, long, double, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, long, double, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, long, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, long, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, long, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, long, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, long, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, double, int, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, double, int, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, double, int, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, double, int, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, double, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, double, float, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, double, float, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, double, float, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, double, float, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, double, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, double, long, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, double, long, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, double, long, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, double, long, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, double, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, double, double, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, double, double, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, double, double, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, double, double, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, double, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, double, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, double, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, double, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, double, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, int, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, int, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, int, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, int, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, float, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, float, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, float, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, float, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, long, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, long, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, long, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, long, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, double, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, double, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, double, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, double, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, int, float, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, int, float, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, int, float, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, int, float, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, int, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, int, long, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, int, long, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, int, long, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, int, long, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, int, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, int, double, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, int, double, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, int, double, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, int, double, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, int, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, int, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, int, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, int, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, int, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, float, int, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, float, int, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, float, int, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, float, int, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, float, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, float, float, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, float, float, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, float, float, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, float, float, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, float, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, float, long, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, float, long, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, float, long, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, float, long, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, float, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, float, double, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, float, double, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, float, double, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, float, double, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, float, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, float, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, float, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, float, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, float, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, long, int, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, long, int, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, long, int, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, long, int, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, long, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, long, float, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, long, float, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, long, float, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, long, float, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, long, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, long, long, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, long, long, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, long, long, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, long, long, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, long, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, long, double, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, long, double, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, long, double, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, long, double, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, long, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, long, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, long, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, long, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, long, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, double, int, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, double, int, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, double, int, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, double, int, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, double, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, double, float, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, double, float, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, double, float, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, double, float, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, double, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, double, long, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, double, long, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, double, long, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, double, long, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, double, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, double, double, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, double, double, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, double, double, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, double, double, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, double, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, double, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, double, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, double, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, double, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, int, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, int, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, int, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, int, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, float, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, float, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, float, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, float, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, long, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, long, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, long, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, long, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, double, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, double, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, double, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, double, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, float, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, float, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, float, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, float, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, long, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, long, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, long, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, long, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, double, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, double, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, double, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, double, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, int, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, int, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, int, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, int, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, float, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, float, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, float, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, float, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, long, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, long, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, long, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, long, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, double, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, double, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, double, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, double, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, int, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, int, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, int, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, int, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, float, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, float, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, float, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, float, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, long, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, long, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, long, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, long, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, double, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, double, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, double, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, double, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, int, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, int, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, int, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, int, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, float, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, float, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, float, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, float, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, long, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, long, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, long, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, long, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, double, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, double, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, double, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, double, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, int, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, int, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, int, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, int, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, float, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, float, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, float, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, float, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, long, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, long, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, long, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, long, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, double, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, double, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, double, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, double, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke22777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, int, int, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, int, int, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, int, int, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, int, int, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, int, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, int, float, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, int, float, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, int, float, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, int, float, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, int, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, int, long, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, int, long, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, int, long, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, int, long, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, int, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, int, double, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, int, double, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, int, double, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, int, double, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, int, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, int, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, int, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, int, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, int, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, float, int, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, float, int, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, float, int, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, float, int, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, float, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, float, float, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, float, float, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, float, float, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, float, float, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, float, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, float, long, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, float, long, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, float, long, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, float, long, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, float, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, float, double, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, float, double, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, float, double, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, float, double, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, float, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, float, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, float, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, float, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, float, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, long, int, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, long, int, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, long, int, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, long, int, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, long, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, long, float, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, long, float, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, long, float, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, long, float, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, long, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, long, long, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, long, long, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, long, long, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, long, long, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, long, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, long, double, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, long, double, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, long, double, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, long, double, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, long, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, long, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, long, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, long, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, long, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, double, int, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, double, int, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, double, int, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, double, int, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, double, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, double, float, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, double, float, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, double, float, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, double, float, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, double, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, double, long, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, double, long, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, double, long, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, double, long, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, double, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, double, double, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, double, double, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, double, double, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, double, double, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, double, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, double, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, double, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, double, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, double, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, int, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, int, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, int, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, int, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, float, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, float, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, float, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, float, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, long, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, long, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, long, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, long, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, double, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, double, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, double, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, double, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, int, int, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, int, int, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, int, int, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, int, int, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, int, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, int, float, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, int, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, int, float, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, int, float, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, int, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, int, long, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, int, long, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, int, long, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, int, long, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, int, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, int, double, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, int, double, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, int, double, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, int, double, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, int, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, int, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, int, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, int, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, int, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, float, int, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, float, int, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, float, int, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, float, int, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, float, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, float, float, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, float, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, float, float, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, float, float, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, float, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, float, long, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, float, long, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, float, long, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, float, long, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, float, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, float, double, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, float, double, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, float, double, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, float, double, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, float, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, float, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, float, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, float, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, float, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, long, int, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, long, int, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, long, int, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, long, int, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, long, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, long, float, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, long, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, long, float, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, long, float, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, long, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, long, long, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, long, long, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, long, long, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, long, long, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, long, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, long, double, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, long, double, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, long, double, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, long, double, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, long, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, long, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, long, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, long, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, long, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, double, int, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, double, int, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, double, int, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, double, int, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, double, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, double, float, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, double, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, double, float, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, double, float, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, double, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, double, long, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, double, long, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, double, long, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, double, long, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, double, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, double, double, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, double, double, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, double, double, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, double, double, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, double, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, double, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, double, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, double, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, double, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, int, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, int, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, int, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, int, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, float, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, float, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, float, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, long, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, long, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, long, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, long, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, double, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, double, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, double, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, double, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, int, int, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, int, int, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, int, int, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, int, int, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, int, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, int, float, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, int, float, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, int, float, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, int, float, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, int, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, int, long, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, int, long, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, int, long, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, int, long, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, int, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, int, double, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, int, double, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, int, double, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, int, double, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, int, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, int, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, int, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, int, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, int, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, float, int, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, float, int, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, float, int, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, float, int, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, float, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, float, float, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, float, float, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, float, float, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, float, float, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, float, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, float, long, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, float, long, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, float, long, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, float, long, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, float, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, float, double, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, float, double, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, float, double, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, float, double, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, float, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, float, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, float, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, float, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, float, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, long, int, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, long, int, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, long, int, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, long, int, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, long, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, long, float, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, long, float, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, long, float, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, long, float, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, long, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, long, long, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, long, long, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, long, long, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, long, long, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, long, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, long, double, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, long, double, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, long, double, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, long, double, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, long, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, long, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, long, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, long, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, long, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, double, int, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, double, int, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, double, int, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, double, int, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, double, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, double, float, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, double, float, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, double, float, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, double, float, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, double, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, double, long, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, double, long, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, double, long, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, double, long, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, double, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, double, double, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, double, double, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, double, double, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, double, double, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, double, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, double, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, double, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, double, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, double, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, int, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, int, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, int, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, int, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, float, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, float, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, float, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, float, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, long, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, long, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, long, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, long, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, double, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, double, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, double, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, double, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, int, int, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, int, int, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, int, int, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, int, int, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, int, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, int, float, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, int, float, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, int, float, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, int, float, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, int, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, int, long, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, int, long, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, int, long, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, int, long, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, int, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, int, double, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, int, double, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, int, double, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, int, double, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, int, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, int, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, int, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, int, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, int, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, float, int, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, float, int, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, float, int, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, float, int, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, float, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, float, float, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, float, float, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, float, float, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, float, float, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, float, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, float, long, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, float, long, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, float, long, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, float, long, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, float, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, float, double, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, float, double, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, float, double, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, float, double, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, float, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, float, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, float, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, float, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, float, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, long, int, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, long, int, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, long, int, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, long, int, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, long, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, long, float, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, long, float, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, long, float, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, long, float, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, long, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, long, long, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, long, long, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, long, long, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, long, long, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, long, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, long, double, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, long, double, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, long, double, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, long, double, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, long, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, long, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, long, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, long, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, long, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, double, int, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, double, int, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, double, int, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, double, int, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, double, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, double, float, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, double, float, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, double, float, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, double, float, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, double, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, double, long, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, double, long, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, double, long, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, double, long, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, double, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, double, double, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, double, double, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, double, double, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, double, double, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, double, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, double, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, double, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, double, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, double, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, int, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, int, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, int, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, int, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, float, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, float, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, float, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, float, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, long, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, long, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, long, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, long, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, double, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, double, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, double, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, double, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, int, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, int, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, int, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, int, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, float, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, float, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, float, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, float, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, long, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, long, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, long, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, long, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, double, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, double, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, double, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, double, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, int, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, int, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, int, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, int, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, float, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, float, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, float, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, float, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, long, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, long, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, long, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, long, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, double, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, double, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, double, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, double, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, int, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, int, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, int, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, int, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, float, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, float, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, float, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, float, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, long, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, long, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, long, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, long, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, double, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, double, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, double, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, double, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, int, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, int, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, int, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, int, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, float, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, float, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, float, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, float, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, long, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, long, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, long, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, long, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, double, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, double, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, double, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, double, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, int, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, int, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, int, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, int, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, float, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, float, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, float, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, float, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, long, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, long, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, long, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, long, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, double, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, double, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, double, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, double, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke26777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, int, int, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, int, int, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, int, int, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, int, int, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, int, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, int, float, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, int, float, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, int, float, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, int, float, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, int, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, int, long, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, int, long, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, int, long, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, int, long, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, int, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, int, double, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, int, double, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, int, double, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, int, double, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, int, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, int, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, int, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, int, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, int, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, float, int, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, float, int, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, float, int, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, float, int, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, float, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, float, float, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, float, float, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, float, float, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, float, float, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, float, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, float, long, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, float, long, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, float, long, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, float, long, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, float, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, float, double, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, float, double, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, float, double, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, float, double, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, float, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, float, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, float, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, float, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, float, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, long, int, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, long, int, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, long, int, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, long, int, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, long, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, long, float, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, long, float, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, long, float, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, long, float, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, long, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, long, long, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, long, long, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, long, long, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, long, long, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, long, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, long, double, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, long, double, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, long, double, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, long, double, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, long, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, long, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, long, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, long, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, long, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, double, int, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, double, int, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, double, int, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, double, int, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, double, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, double, float, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, double, float, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, double, float, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, double, float, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, double, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, double, long, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, double, long, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, double, long, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, double, long, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, double, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, double, double, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, double, double, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, double, double, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, double, double, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, double, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, double, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, double, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, double, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, double, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, int, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, int, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, int, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, int, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, float, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, float, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, float, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, float, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, long, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, long, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, long, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, long, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, double, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, double, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, double, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, double, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, int, int, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, int, int, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, int, int, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, int, int, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, int, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, int, float, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, int, float, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, int, float, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, int, float, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, int, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, int, long, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, int, long, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, int, long, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, int, long, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, int, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, int, double, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, int, double, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, int, double, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, int, double, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, int, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, int, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, int, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, int, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, int, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, float, int, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, float, int, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, float, int, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, float, int, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, float, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, float, float, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, float, float, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, float, float, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, float, float, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, float, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, float, long, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, float, long, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, float, long, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, float, long, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, float, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, float, double, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, float, double, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, float, double, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, float, double, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, float, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, float, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, float, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, float, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, float, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, long, int, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, long, int, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, long, int, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, long, int, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, long, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, long, float, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, long, float, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, long, float, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, long, float, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, long, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, long, long, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, long, long, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, long, long, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, long, long, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, long, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, long, double, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, long, double, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, long, double, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, long, double, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, long, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, long, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, long, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, long, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, long, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, double, int, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, double, int, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, double, int, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, double, int, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, double, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, double, float, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, double, float, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, double, float, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, double, float, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, double, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, double, long, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, double, long, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, double, long, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, double, long, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, double, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, double, double, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, double, double, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, double, double, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, double, double, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, double, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, double, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, double, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, double, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, double, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, int, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, int, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, int, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, int, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, float, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, float, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, float, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, float, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, long, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, long, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, long, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, long, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, double, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, double, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, double, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, double, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, int, int, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, int, int, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, int, int, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, int, int, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, int, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, int, float, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, int, float, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, int, float, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, int, float, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, int, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, int, long, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, int, long, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, int, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, int, long, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, int, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, int, double, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, int, double, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, int, double, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, int, double, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, int, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, int, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, int, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, int, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, int, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, float, int, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, float, int, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, float, int, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, float, int, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, float, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, float, float, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, float, float, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, float, float, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, float, float, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, float, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, float, long, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, float, long, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, float, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, float, long, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, float, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, float, double, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, float, double, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, float, double, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, float, double, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, float, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, float, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, float, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, float, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, float, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, long, int, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, long, int, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, long, int, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, long, int, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, long, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, long, float, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, long, float, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, long, float, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, long, float, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, long, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, long, long, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, long, long, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, long, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, long, long, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, long, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, long, double, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, long, double, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, long, double, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, long, double, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, long, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, long, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, long, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, long, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, long, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, double, int, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, double, int, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, double, int, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, double, int, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, double, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, double, float, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, double, float, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, double, float, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, double, float, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, double, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, double, long, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, double, long, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, double, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, double, long, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, double, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, double, double, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, double, double, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, double, double, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, double, double, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, double, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, double, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, double, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, double, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, double, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, int, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, int, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, int, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, int, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, float, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, float, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, float, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, float, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, long, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, long, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, long, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, double, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, double, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, double, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, double, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, int, int, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, int, int, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, int, int, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, int, int, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, int, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, int, float, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, int, float, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, int, float, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, int, float, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, int, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, int, long, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, int, long, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, int, long, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, int, long, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, int, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, int, double, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, int, double, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, int, double, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, int, double, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, int, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, int, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, int, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, int, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, int, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, float, int, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, float, int, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, float, int, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, float, int, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, float, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, float, float, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, float, float, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, float, float, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, float, float, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, float, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, float, long, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, float, long, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, float, long, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, float, long, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, float, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, float, double, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, float, double, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, float, double, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, float, double, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, float, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, float, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, float, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, float, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, float, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, long, int, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, long, int, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, long, int, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, long, int, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, long, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, long, float, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, long, float, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, long, float, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, long, float, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, long, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, long, long, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, long, long, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, long, long, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, long, long, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, long, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, long, double, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, long, double, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, long, double, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, long, double, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, long, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, long, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, long, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, long, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, long, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, double, int, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, double, int, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, double, int, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, double, int, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, double, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, double, float, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, double, float, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, double, float, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, double, float, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, double, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, double, long, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, double, long, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, double, long, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, double, long, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, double, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, double, double, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, double, double, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, double, double, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, double, double, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, double, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, double, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, double, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, double, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, double, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, int, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, int, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, int, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, int, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, float, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, float, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, float, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, float, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, long, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, long, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, long, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, long, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, double, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, double, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, double, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, double, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, int, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, int, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, int, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, int, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, float, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, float, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, float, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, float, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, long, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, long, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, long, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, long, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, double, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, double, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, double, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, double, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, int, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, int, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, int, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, int, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, float, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, float, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, float, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, float, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, long, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, long, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, long, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, long, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, double, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, double, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, double, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, double, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, int, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, int, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, int, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, int, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, float, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, float, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, float, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, float, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, long, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, long, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, long, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, long, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, double, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, double, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, double, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, double, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, int, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, int, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, int, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, int, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, float, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, float, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, float, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, float, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, long, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, long, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, long, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, long, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, double, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, double, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, double, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, double, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, int, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, int, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, int, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, int, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, float, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, float, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, float, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, float, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, long, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, long, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, long, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, long, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, double, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, double, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, double, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, double, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke23777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, int, int, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, int, int, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, int, int, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, int, int, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, int, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, int, float, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, int, float, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, int, float, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, int, float, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, int, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, int, long, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, int, long, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, int, long, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, int, long, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, int, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, int, double, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, int, double, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, int, double, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, int, double, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, int, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, int, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, int, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, int, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, int, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, float, int, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, float, int, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, float, int, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, float, int, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, float, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, float, float, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, float, float, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, float, float, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, float, float, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, float, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, float, long, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, float, long, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, float, long, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, float, long, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, float, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, float, double, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, float, double, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, float, double, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, float, double, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, float, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, float, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, float, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, float, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, float, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, long, int, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, long, int, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, long, int, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, long, int, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, long, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, long, float, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, long, float, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, long, float, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, long, float, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, long, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, long, long, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, long, long, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, long, long, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, long, long, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, long, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, long, double, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, long, double, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, long, double, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, long, double, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, long, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, long, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, long, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, long, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, long, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, double, int, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, double, int, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, double, int, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, double, int, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, double, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, double, float, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, double, float, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, double, float, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, double, float, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, double, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, double, long, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, double, long, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, double, long, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, double, long, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, double, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, double, double, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, double, double, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, double, double, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, double, double, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, double, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, double, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, double, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, double, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, double, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, int, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, int, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, int, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, int, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, float, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, float, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, float, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, float, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, long, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, long, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, long, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, long, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, double, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, double, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, double, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, double, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, int, int, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, int, int, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, int, int, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, int, int, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, int, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, int, float, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, int, float, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, int, float, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, int, float, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, int, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, int, long, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, int, long, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, int, long, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, int, long, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, int, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, int, double, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, int, double, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, int, double, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, int, double, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, int, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, int, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, int, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, int, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, int, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, float, int, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, float, int, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, float, int, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, float, int, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, float, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, float, float, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, float, float, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, float, float, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, float, float, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, float, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, float, long, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, float, long, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, float, long, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, float, long, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, float, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, float, double, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, float, double, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, float, double, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, float, double, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, float, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, float, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, float, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, float, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, float, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, long, int, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, long, int, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, long, int, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, long, int, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, long, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, long, float, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, long, float, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, long, float, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, long, float, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, long, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, long, long, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, long, long, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, long, long, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, long, long, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, long, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, long, double, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, long, double, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, long, double, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, long, double, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, long, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, long, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, long, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, long, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, long, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, double, int, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, double, int, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, double, int, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, double, int, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, double, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, double, float, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, double, float, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, double, float, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, double, float, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, double, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, double, long, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, double, long, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, double, long, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, double, long, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, double, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, double, double, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, double, double, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, double, double, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, double, double, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, double, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, double, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, double, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, double, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, double, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, int, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, int, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, int, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, int, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, float, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, float, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, float, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, float, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, long, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, long, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, long, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, long, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, double, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, double, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, double, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, double, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, int, int, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, int, int, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, int, int, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, int, int, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, int, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, int, float, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, int, float, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, int, float, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, int, float, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, int, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, int, long, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, int, long, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, int, long, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, int, long, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, int, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, int, double, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, int, double, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, int, double, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, int, double, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, int, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, int, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, int, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, int, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, int, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, float, int, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, float, int, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, float, int, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, float, int, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, float, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, float, float, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, float, float, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, float, float, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, float, float, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, float, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, float, long, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, float, long, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, float, long, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, float, long, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, float, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, float, double, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, float, double, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, float, double, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, float, double, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, float, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, float, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, float, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, float, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, float, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, long, int, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, long, int, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, long, int, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, long, int, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, long, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, long, float, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, long, float, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, long, float, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, long, float, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, long, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, long, long, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, long, long, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, long, long, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, long, long, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, long, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, long, double, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, long, double, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, long, double, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, long, double, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, long, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, long, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, long, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, long, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, long, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, double, int, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, double, int, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, double, int, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, double, int, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, double, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, double, float, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, double, float, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, double, float, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, double, float, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, double, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, double, long, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, double, long, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, double, long, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, double, long, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, double, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, double, double, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, double, double, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, double, double, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, double, double, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, double, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, double, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, double, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, double, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, double, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, int, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, int, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, int, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, int, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, float, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, float, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, float, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, float, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, long, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, long, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, long, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, long, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, double, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, double, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, double, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, double, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, int, int, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, int, int, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, int, int, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, int, int, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, int, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, int, float, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, int, float, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, int, float, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, int, float, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, int, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, int, long, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, int, long, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, int, long, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, int, long, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, int, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, int, double, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, int, double, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, int, double, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, int, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, int, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, int, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, int, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, int, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, int, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, float, int, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, float, int, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, float, int, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, float, int, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, float, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, float, float, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, float, float, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, float, float, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, float, float, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, float, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, float, long, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, float, long, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, float, long, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, float, long, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, float, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, float, double, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, float, double, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, float, double, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, float, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, float, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, float, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, float, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, float, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, float, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, long, int, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, long, int, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, long, int, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, long, int, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, long, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, long, float, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, long, float, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, long, float, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, long, float, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, long, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, long, long, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, long, long, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, long, long, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, long, long, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, long, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, long, double, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, long, double, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, long, double, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, long, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, long, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, long, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, long, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, long, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, long, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, double, int, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, double, int, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, double, int, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, double, int, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, double, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, double, float, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, double, float, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, double, float, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, double, float, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, double, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, double, long, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, double, long, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, double, long, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, double, long, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, double, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, double, double, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, double, double, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, double, double, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, double, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, double, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, double, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, double, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, double, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, double, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, int, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, int, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, int, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, int, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, float, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, float, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, float, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, float, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, long, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, long, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, long, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, long, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, double, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, double, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, double, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, int, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, int, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, int, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, int, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, float, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, float, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, float, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, float, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, long, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, long, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, long, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, long, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, double, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, double, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, double, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, double, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, int, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, int, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, int, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, int, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, float, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, float, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, float, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, float, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, long, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, long, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, long, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, long, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, double, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, double, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, double, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, double, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, int, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, int, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, int, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, int, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, float, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, float, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, float, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, float, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, long, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, long, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, long, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, long, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, double, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, double, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, double, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, double, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, int, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, int, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, int, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, int, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, float, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, float, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, float, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, float, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, long, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, long, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, long, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, long, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, double, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, double, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, double, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, double, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, int, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, int, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, int, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, int, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, float, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, float, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, float, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, float, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, long, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, long, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, long, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, long, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, double, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, double, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, double, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, double, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke25777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke27777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}
}
