using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S5
{
	public static int Invoke(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[0] switch
		{
			'2' => Invoke2XXXX(code, p, args), 
			'6' => Invoke6XXXX(code, p, args), 
			'3' => Invoke3XXXX(code, p, args), 
			'5' => Invoke5XXXX(code, p, args), 
			'7' => Invoke7XXXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke2XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke22XXX(code, p, args), 
			'6' => Invoke26XXX(code, p, args), 
			'3' => Invoke23XXX(code, p, args), 
			'5' => Invoke25XXX(code, p, args), 
			'7' => Invoke27XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke22XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke222XX(code, p, args), 
			'6' => Invoke226XX(code, p, args), 
			'3' => Invoke223XX(code, p, args), 
			'5' => Invoke225XX(code, p, args), 
			'7' => Invoke227XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke222XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2222X(code, p, args), 
			'6' => Invoke2226X(code, p, args), 
			'3' => Invoke2223X(code, p, args), 
			'5' => Invoke2225X(code, p, args), 
			'7' => Invoke2227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke226XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2262X(code, p, args), 
			'6' => Invoke2266X(code, p, args), 
			'3' => Invoke2263X(code, p, args), 
			'5' => Invoke2265X(code, p, args), 
			'7' => Invoke2267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke223XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2232X(code, p, args), 
			'6' => Invoke2236X(code, p, args), 
			'3' => Invoke2233X(code, p, args), 
			'5' => Invoke2235X(code, p, args), 
			'7' => Invoke2237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke225XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2252X(code, p, args), 
			'6' => Invoke2256X(code, p, args), 
			'3' => Invoke2253X(code, p, args), 
			'5' => Invoke2255X(code, p, args), 
			'7' => Invoke2257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke227XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2272X(code, p, args), 
			'6' => Invoke2276X(code, p, args), 
			'3' => Invoke2273X(code, p, args), 
			'5' => Invoke2275X(code, p, args), 
			'7' => Invoke2277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke26XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke262XX(code, p, args), 
			'6' => Invoke266XX(code, p, args), 
			'3' => Invoke263XX(code, p, args), 
			'5' => Invoke265XX(code, p, args), 
			'7' => Invoke267XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke262XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2622X(code, p, args), 
			'6' => Invoke2626X(code, p, args), 
			'3' => Invoke2623X(code, p, args), 
			'5' => Invoke2625X(code, p, args), 
			'7' => Invoke2627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke266XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2662X(code, p, args), 
			'6' => Invoke2666X(code, p, args), 
			'3' => Invoke2663X(code, p, args), 
			'5' => Invoke2665X(code, p, args), 
			'7' => Invoke2667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke263XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2632X(code, p, args), 
			'6' => Invoke2636X(code, p, args), 
			'3' => Invoke2633X(code, p, args), 
			'5' => Invoke2635X(code, p, args), 
			'7' => Invoke2637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke265XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2652X(code, p, args), 
			'6' => Invoke2656X(code, p, args), 
			'3' => Invoke2653X(code, p, args), 
			'5' => Invoke2655X(code, p, args), 
			'7' => Invoke2657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke267XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2672X(code, p, args), 
			'6' => Invoke2676X(code, p, args), 
			'3' => Invoke2673X(code, p, args), 
			'5' => Invoke2675X(code, p, args), 
			'7' => Invoke2677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke23XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke232XX(code, p, args), 
			'6' => Invoke236XX(code, p, args), 
			'3' => Invoke233XX(code, p, args), 
			'5' => Invoke235XX(code, p, args), 
			'7' => Invoke237XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke232XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2322X(code, p, args), 
			'6' => Invoke2326X(code, p, args), 
			'3' => Invoke2323X(code, p, args), 
			'5' => Invoke2325X(code, p, args), 
			'7' => Invoke2327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke236XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2362X(code, p, args), 
			'6' => Invoke2366X(code, p, args), 
			'3' => Invoke2363X(code, p, args), 
			'5' => Invoke2365X(code, p, args), 
			'7' => Invoke2367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke233XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2332X(code, p, args), 
			'6' => Invoke2336X(code, p, args), 
			'3' => Invoke2333X(code, p, args), 
			'5' => Invoke2335X(code, p, args), 
			'7' => Invoke2337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke235XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2352X(code, p, args), 
			'6' => Invoke2356X(code, p, args), 
			'3' => Invoke2353X(code, p, args), 
			'5' => Invoke2355X(code, p, args), 
			'7' => Invoke2357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke237XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2372X(code, p, args), 
			'6' => Invoke2376X(code, p, args), 
			'3' => Invoke2373X(code, p, args), 
			'5' => Invoke2375X(code, p, args), 
			'7' => Invoke2377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke25XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke252XX(code, p, args), 
			'6' => Invoke256XX(code, p, args), 
			'3' => Invoke253XX(code, p, args), 
			'5' => Invoke255XX(code, p, args), 
			'7' => Invoke257XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke252XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2522X(code, p, args), 
			'6' => Invoke2526X(code, p, args), 
			'3' => Invoke2523X(code, p, args), 
			'5' => Invoke2525X(code, p, args), 
			'7' => Invoke2527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke256XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2562X(code, p, args), 
			'6' => Invoke2566X(code, p, args), 
			'3' => Invoke2563X(code, p, args), 
			'5' => Invoke2565X(code, p, args), 
			'7' => Invoke2567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke253XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2532X(code, p, args), 
			'6' => Invoke2536X(code, p, args), 
			'3' => Invoke2533X(code, p, args), 
			'5' => Invoke2535X(code, p, args), 
			'7' => Invoke2537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke255XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2552X(code, p, args), 
			'6' => Invoke2556X(code, p, args), 
			'3' => Invoke2553X(code, p, args), 
			'5' => Invoke2555X(code, p, args), 
			'7' => Invoke2557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke257XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2572X(code, p, args), 
			'6' => Invoke2576X(code, p, args), 
			'3' => Invoke2573X(code, p, args), 
			'5' => Invoke2575X(code, p, args), 
			'7' => Invoke2577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke27XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke272XX(code, p, args), 
			'6' => Invoke276XX(code, p, args), 
			'3' => Invoke273XX(code, p, args), 
			'5' => Invoke275XX(code, p, args), 
			'7' => Invoke277XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke272XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2722X(code, p, args), 
			'6' => Invoke2726X(code, p, args), 
			'3' => Invoke2723X(code, p, args), 
			'5' => Invoke2725X(code, p, args), 
			'7' => Invoke2727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke276XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2762X(code, p, args), 
			'6' => Invoke2766X(code, p, args), 
			'3' => Invoke2763X(code, p, args), 
			'5' => Invoke2765X(code, p, args), 
			'7' => Invoke2767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke273XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2732X(code, p, args), 
			'6' => Invoke2736X(code, p, args), 
			'3' => Invoke2733X(code, p, args), 
			'5' => Invoke2735X(code, p, args), 
			'7' => Invoke2737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke275XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2752X(code, p, args), 
			'6' => Invoke2756X(code, p, args), 
			'3' => Invoke2753X(code, p, args), 
			'5' => Invoke2755X(code, p, args), 
			'7' => Invoke2757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke277XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke2772X(code, p, args), 
			'6' => Invoke2776X(code, p, args), 
			'3' => Invoke2773X(code, p, args), 
			'5' => Invoke2775X(code, p, args), 
			'7' => Invoke2777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke6XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke62XXX(code, p, args), 
			'6' => Invoke66XXX(code, p, args), 
			'3' => Invoke63XXX(code, p, args), 
			'5' => Invoke65XXX(code, p, args), 
			'7' => Invoke67XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke62XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke622XX(code, p, args), 
			'6' => Invoke626XX(code, p, args), 
			'3' => Invoke623XX(code, p, args), 
			'5' => Invoke625XX(code, p, args), 
			'7' => Invoke627XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke622XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6222X(code, p, args), 
			'6' => Invoke6226X(code, p, args), 
			'3' => Invoke6223X(code, p, args), 
			'5' => Invoke6225X(code, p, args), 
			'7' => Invoke6227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke626XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6262X(code, p, args), 
			'6' => Invoke6266X(code, p, args), 
			'3' => Invoke6263X(code, p, args), 
			'5' => Invoke6265X(code, p, args), 
			'7' => Invoke6267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke623XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6232X(code, p, args), 
			'6' => Invoke6236X(code, p, args), 
			'3' => Invoke6233X(code, p, args), 
			'5' => Invoke6235X(code, p, args), 
			'7' => Invoke6237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke625XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6252X(code, p, args), 
			'6' => Invoke6256X(code, p, args), 
			'3' => Invoke6253X(code, p, args), 
			'5' => Invoke6255X(code, p, args), 
			'7' => Invoke6257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke627XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6272X(code, p, args), 
			'6' => Invoke6276X(code, p, args), 
			'3' => Invoke6273X(code, p, args), 
			'5' => Invoke6275X(code, p, args), 
			'7' => Invoke6277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke66XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke662XX(code, p, args), 
			'6' => Invoke666XX(code, p, args), 
			'3' => Invoke663XX(code, p, args), 
			'5' => Invoke665XX(code, p, args), 
			'7' => Invoke667XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke662XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6622X(code, p, args), 
			'6' => Invoke6626X(code, p, args), 
			'3' => Invoke6623X(code, p, args), 
			'5' => Invoke6625X(code, p, args), 
			'7' => Invoke6627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke666XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6662X(code, p, args), 
			'6' => Invoke6666X(code, p, args), 
			'3' => Invoke6663X(code, p, args), 
			'5' => Invoke6665X(code, p, args), 
			'7' => Invoke6667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke663XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6632X(code, p, args), 
			'6' => Invoke6636X(code, p, args), 
			'3' => Invoke6633X(code, p, args), 
			'5' => Invoke6635X(code, p, args), 
			'7' => Invoke6637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke665XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6652X(code, p, args), 
			'6' => Invoke6656X(code, p, args), 
			'3' => Invoke6653X(code, p, args), 
			'5' => Invoke6655X(code, p, args), 
			'7' => Invoke6657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke667XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6672X(code, p, args), 
			'6' => Invoke6676X(code, p, args), 
			'3' => Invoke6673X(code, p, args), 
			'5' => Invoke6675X(code, p, args), 
			'7' => Invoke6677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke63XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke632XX(code, p, args), 
			'6' => Invoke636XX(code, p, args), 
			'3' => Invoke633XX(code, p, args), 
			'5' => Invoke635XX(code, p, args), 
			'7' => Invoke637XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke632XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6322X(code, p, args), 
			'6' => Invoke6326X(code, p, args), 
			'3' => Invoke6323X(code, p, args), 
			'5' => Invoke6325X(code, p, args), 
			'7' => Invoke6327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke636XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6362X(code, p, args), 
			'6' => Invoke6366X(code, p, args), 
			'3' => Invoke6363X(code, p, args), 
			'5' => Invoke6365X(code, p, args), 
			'7' => Invoke6367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke633XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6332X(code, p, args), 
			'6' => Invoke6336X(code, p, args), 
			'3' => Invoke6333X(code, p, args), 
			'5' => Invoke6335X(code, p, args), 
			'7' => Invoke6337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke635XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6352X(code, p, args), 
			'6' => Invoke6356X(code, p, args), 
			'3' => Invoke6353X(code, p, args), 
			'5' => Invoke6355X(code, p, args), 
			'7' => Invoke6357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke637XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6372X(code, p, args), 
			'6' => Invoke6376X(code, p, args), 
			'3' => Invoke6373X(code, p, args), 
			'5' => Invoke6375X(code, p, args), 
			'7' => Invoke6377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke65XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke652XX(code, p, args), 
			'6' => Invoke656XX(code, p, args), 
			'3' => Invoke653XX(code, p, args), 
			'5' => Invoke655XX(code, p, args), 
			'7' => Invoke657XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke652XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6522X(code, p, args), 
			'6' => Invoke6526X(code, p, args), 
			'3' => Invoke6523X(code, p, args), 
			'5' => Invoke6525X(code, p, args), 
			'7' => Invoke6527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke656XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6562X(code, p, args), 
			'6' => Invoke6566X(code, p, args), 
			'3' => Invoke6563X(code, p, args), 
			'5' => Invoke6565X(code, p, args), 
			'7' => Invoke6567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke653XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6532X(code, p, args), 
			'6' => Invoke6536X(code, p, args), 
			'3' => Invoke6533X(code, p, args), 
			'5' => Invoke6535X(code, p, args), 
			'7' => Invoke6537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke655XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6552X(code, p, args), 
			'6' => Invoke6556X(code, p, args), 
			'3' => Invoke6553X(code, p, args), 
			'5' => Invoke6555X(code, p, args), 
			'7' => Invoke6557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke657XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6572X(code, p, args), 
			'6' => Invoke6576X(code, p, args), 
			'3' => Invoke6573X(code, p, args), 
			'5' => Invoke6575X(code, p, args), 
			'7' => Invoke6577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke67XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke672XX(code, p, args), 
			'6' => Invoke676XX(code, p, args), 
			'3' => Invoke673XX(code, p, args), 
			'5' => Invoke675XX(code, p, args), 
			'7' => Invoke677XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke672XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6722X(code, p, args), 
			'6' => Invoke6726X(code, p, args), 
			'3' => Invoke6723X(code, p, args), 
			'5' => Invoke6725X(code, p, args), 
			'7' => Invoke6727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke676XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6762X(code, p, args), 
			'6' => Invoke6766X(code, p, args), 
			'3' => Invoke6763X(code, p, args), 
			'5' => Invoke6765X(code, p, args), 
			'7' => Invoke6767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke673XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6732X(code, p, args), 
			'6' => Invoke6736X(code, p, args), 
			'3' => Invoke6733X(code, p, args), 
			'5' => Invoke6735X(code, p, args), 
			'7' => Invoke6737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke675XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6752X(code, p, args), 
			'6' => Invoke6756X(code, p, args), 
			'3' => Invoke6753X(code, p, args), 
			'5' => Invoke6755X(code, p, args), 
			'7' => Invoke6757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke677XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke6772X(code, p, args), 
			'6' => Invoke6776X(code, p, args), 
			'3' => Invoke6773X(code, p, args), 
			'5' => Invoke6775X(code, p, args), 
			'7' => Invoke6777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke3XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke32XXX(code, p, args), 
			'6' => Invoke36XXX(code, p, args), 
			'3' => Invoke33XXX(code, p, args), 
			'5' => Invoke35XXX(code, p, args), 
			'7' => Invoke37XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke32XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke322XX(code, p, args), 
			'6' => Invoke326XX(code, p, args), 
			'3' => Invoke323XX(code, p, args), 
			'5' => Invoke325XX(code, p, args), 
			'7' => Invoke327XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke322XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3222X(code, p, args), 
			'6' => Invoke3226X(code, p, args), 
			'3' => Invoke3223X(code, p, args), 
			'5' => Invoke3225X(code, p, args), 
			'7' => Invoke3227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke326XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3262X(code, p, args), 
			'6' => Invoke3266X(code, p, args), 
			'3' => Invoke3263X(code, p, args), 
			'5' => Invoke3265X(code, p, args), 
			'7' => Invoke3267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke323XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3232X(code, p, args), 
			'6' => Invoke3236X(code, p, args), 
			'3' => Invoke3233X(code, p, args), 
			'5' => Invoke3235X(code, p, args), 
			'7' => Invoke3237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke325XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3252X(code, p, args), 
			'6' => Invoke3256X(code, p, args), 
			'3' => Invoke3253X(code, p, args), 
			'5' => Invoke3255X(code, p, args), 
			'7' => Invoke3257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke327XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3272X(code, p, args), 
			'6' => Invoke3276X(code, p, args), 
			'3' => Invoke3273X(code, p, args), 
			'5' => Invoke3275X(code, p, args), 
			'7' => Invoke3277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke36XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke362XX(code, p, args), 
			'6' => Invoke366XX(code, p, args), 
			'3' => Invoke363XX(code, p, args), 
			'5' => Invoke365XX(code, p, args), 
			'7' => Invoke367XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke362XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3622X(code, p, args), 
			'6' => Invoke3626X(code, p, args), 
			'3' => Invoke3623X(code, p, args), 
			'5' => Invoke3625X(code, p, args), 
			'7' => Invoke3627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke366XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3662X(code, p, args), 
			'6' => Invoke3666X(code, p, args), 
			'3' => Invoke3663X(code, p, args), 
			'5' => Invoke3665X(code, p, args), 
			'7' => Invoke3667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke363XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3632X(code, p, args), 
			'6' => Invoke3636X(code, p, args), 
			'3' => Invoke3633X(code, p, args), 
			'5' => Invoke3635X(code, p, args), 
			'7' => Invoke3637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke365XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3652X(code, p, args), 
			'6' => Invoke3656X(code, p, args), 
			'3' => Invoke3653X(code, p, args), 
			'5' => Invoke3655X(code, p, args), 
			'7' => Invoke3657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke367XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3672X(code, p, args), 
			'6' => Invoke3676X(code, p, args), 
			'3' => Invoke3673X(code, p, args), 
			'5' => Invoke3675X(code, p, args), 
			'7' => Invoke3677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke33XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke332XX(code, p, args), 
			'6' => Invoke336XX(code, p, args), 
			'3' => Invoke333XX(code, p, args), 
			'5' => Invoke335XX(code, p, args), 
			'7' => Invoke337XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke332XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3322X(code, p, args), 
			'6' => Invoke3326X(code, p, args), 
			'3' => Invoke3323X(code, p, args), 
			'5' => Invoke3325X(code, p, args), 
			'7' => Invoke3327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke336XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3362X(code, p, args), 
			'6' => Invoke3366X(code, p, args), 
			'3' => Invoke3363X(code, p, args), 
			'5' => Invoke3365X(code, p, args), 
			'7' => Invoke3367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke333XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3332X(code, p, args), 
			'6' => Invoke3336X(code, p, args), 
			'3' => Invoke3333X(code, p, args), 
			'5' => Invoke3335X(code, p, args), 
			'7' => Invoke3337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke335XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3352X(code, p, args), 
			'6' => Invoke3356X(code, p, args), 
			'3' => Invoke3353X(code, p, args), 
			'5' => Invoke3355X(code, p, args), 
			'7' => Invoke3357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke337XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3372X(code, p, args), 
			'6' => Invoke3376X(code, p, args), 
			'3' => Invoke3373X(code, p, args), 
			'5' => Invoke3375X(code, p, args), 
			'7' => Invoke3377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke35XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke352XX(code, p, args), 
			'6' => Invoke356XX(code, p, args), 
			'3' => Invoke353XX(code, p, args), 
			'5' => Invoke355XX(code, p, args), 
			'7' => Invoke357XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke352XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3522X(code, p, args), 
			'6' => Invoke3526X(code, p, args), 
			'3' => Invoke3523X(code, p, args), 
			'5' => Invoke3525X(code, p, args), 
			'7' => Invoke3527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke356XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3562X(code, p, args), 
			'6' => Invoke3566X(code, p, args), 
			'3' => Invoke3563X(code, p, args), 
			'5' => Invoke3565X(code, p, args), 
			'7' => Invoke3567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke353XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3532X(code, p, args), 
			'6' => Invoke3536X(code, p, args), 
			'3' => Invoke3533X(code, p, args), 
			'5' => Invoke3535X(code, p, args), 
			'7' => Invoke3537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke355XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3552X(code, p, args), 
			'6' => Invoke3556X(code, p, args), 
			'3' => Invoke3553X(code, p, args), 
			'5' => Invoke3555X(code, p, args), 
			'7' => Invoke3557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke357XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3572X(code, p, args), 
			'6' => Invoke3576X(code, p, args), 
			'3' => Invoke3573X(code, p, args), 
			'5' => Invoke3575X(code, p, args), 
			'7' => Invoke3577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke37XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke372XX(code, p, args), 
			'6' => Invoke376XX(code, p, args), 
			'3' => Invoke373XX(code, p, args), 
			'5' => Invoke375XX(code, p, args), 
			'7' => Invoke377XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke372XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3722X(code, p, args), 
			'6' => Invoke3726X(code, p, args), 
			'3' => Invoke3723X(code, p, args), 
			'5' => Invoke3725X(code, p, args), 
			'7' => Invoke3727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke376XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3762X(code, p, args), 
			'6' => Invoke3766X(code, p, args), 
			'3' => Invoke3763X(code, p, args), 
			'5' => Invoke3765X(code, p, args), 
			'7' => Invoke3767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke373XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3732X(code, p, args), 
			'6' => Invoke3736X(code, p, args), 
			'3' => Invoke3733X(code, p, args), 
			'5' => Invoke3735X(code, p, args), 
			'7' => Invoke3737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke375XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3752X(code, p, args), 
			'6' => Invoke3756X(code, p, args), 
			'3' => Invoke3753X(code, p, args), 
			'5' => Invoke3755X(code, p, args), 
			'7' => Invoke3757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke377XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke3772X(code, p, args), 
			'6' => Invoke3776X(code, p, args), 
			'3' => Invoke3773X(code, p, args), 
			'5' => Invoke3775X(code, p, args), 
			'7' => Invoke3777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke52XXX(code, p, args), 
			'6' => Invoke56XXX(code, p, args), 
			'3' => Invoke53XXX(code, p, args), 
			'5' => Invoke55XXX(code, p, args), 
			'7' => Invoke57XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke52XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke522XX(code, p, args), 
			'6' => Invoke526XX(code, p, args), 
			'3' => Invoke523XX(code, p, args), 
			'5' => Invoke525XX(code, p, args), 
			'7' => Invoke527XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke522XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5222X(code, p, args), 
			'6' => Invoke5226X(code, p, args), 
			'3' => Invoke5223X(code, p, args), 
			'5' => Invoke5225X(code, p, args), 
			'7' => Invoke5227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke526XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5262X(code, p, args), 
			'6' => Invoke5266X(code, p, args), 
			'3' => Invoke5263X(code, p, args), 
			'5' => Invoke5265X(code, p, args), 
			'7' => Invoke5267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke523XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5232X(code, p, args), 
			'6' => Invoke5236X(code, p, args), 
			'3' => Invoke5233X(code, p, args), 
			'5' => Invoke5235X(code, p, args), 
			'7' => Invoke5237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke525XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5252X(code, p, args), 
			'6' => Invoke5256X(code, p, args), 
			'3' => Invoke5253X(code, p, args), 
			'5' => Invoke5255X(code, p, args), 
			'7' => Invoke5257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke527XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5272X(code, p, args), 
			'6' => Invoke5276X(code, p, args), 
			'3' => Invoke5273X(code, p, args), 
			'5' => Invoke5275X(code, p, args), 
			'7' => Invoke5277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke56XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke562XX(code, p, args), 
			'6' => Invoke566XX(code, p, args), 
			'3' => Invoke563XX(code, p, args), 
			'5' => Invoke565XX(code, p, args), 
			'7' => Invoke567XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke562XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5622X(code, p, args), 
			'6' => Invoke5626X(code, p, args), 
			'3' => Invoke5623X(code, p, args), 
			'5' => Invoke5625X(code, p, args), 
			'7' => Invoke5627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke566XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5662X(code, p, args), 
			'6' => Invoke5666X(code, p, args), 
			'3' => Invoke5663X(code, p, args), 
			'5' => Invoke5665X(code, p, args), 
			'7' => Invoke5667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke563XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5632X(code, p, args), 
			'6' => Invoke5636X(code, p, args), 
			'3' => Invoke5633X(code, p, args), 
			'5' => Invoke5635X(code, p, args), 
			'7' => Invoke5637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke565XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5652X(code, p, args), 
			'6' => Invoke5656X(code, p, args), 
			'3' => Invoke5653X(code, p, args), 
			'5' => Invoke5655X(code, p, args), 
			'7' => Invoke5657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke567XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5672X(code, p, args), 
			'6' => Invoke5676X(code, p, args), 
			'3' => Invoke5673X(code, p, args), 
			'5' => Invoke5675X(code, p, args), 
			'7' => Invoke5677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke53XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke532XX(code, p, args), 
			'6' => Invoke536XX(code, p, args), 
			'3' => Invoke533XX(code, p, args), 
			'5' => Invoke535XX(code, p, args), 
			'7' => Invoke537XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke532XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5322X(code, p, args), 
			'6' => Invoke5326X(code, p, args), 
			'3' => Invoke5323X(code, p, args), 
			'5' => Invoke5325X(code, p, args), 
			'7' => Invoke5327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke536XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5362X(code, p, args), 
			'6' => Invoke5366X(code, p, args), 
			'3' => Invoke5363X(code, p, args), 
			'5' => Invoke5365X(code, p, args), 
			'7' => Invoke5367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke533XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5332X(code, p, args), 
			'6' => Invoke5336X(code, p, args), 
			'3' => Invoke5333X(code, p, args), 
			'5' => Invoke5335X(code, p, args), 
			'7' => Invoke5337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke535XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5352X(code, p, args), 
			'6' => Invoke5356X(code, p, args), 
			'3' => Invoke5353X(code, p, args), 
			'5' => Invoke5355X(code, p, args), 
			'7' => Invoke5357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke537XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5372X(code, p, args), 
			'6' => Invoke5376X(code, p, args), 
			'3' => Invoke5373X(code, p, args), 
			'5' => Invoke5375X(code, p, args), 
			'7' => Invoke5377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke55XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke552XX(code, p, args), 
			'6' => Invoke556XX(code, p, args), 
			'3' => Invoke553XX(code, p, args), 
			'5' => Invoke555XX(code, p, args), 
			'7' => Invoke557XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke552XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5522X(code, p, args), 
			'6' => Invoke5526X(code, p, args), 
			'3' => Invoke5523X(code, p, args), 
			'5' => Invoke5525X(code, p, args), 
			'7' => Invoke5527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke556XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5562X(code, p, args), 
			'6' => Invoke5566X(code, p, args), 
			'3' => Invoke5563X(code, p, args), 
			'5' => Invoke5565X(code, p, args), 
			'7' => Invoke5567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke553XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5532X(code, p, args), 
			'6' => Invoke5536X(code, p, args), 
			'3' => Invoke5533X(code, p, args), 
			'5' => Invoke5535X(code, p, args), 
			'7' => Invoke5537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke555XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5552X(code, p, args), 
			'6' => Invoke5556X(code, p, args), 
			'3' => Invoke5553X(code, p, args), 
			'5' => Invoke5555X(code, p, args), 
			'7' => Invoke5557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke557XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5572X(code, p, args), 
			'6' => Invoke5576X(code, p, args), 
			'3' => Invoke5573X(code, p, args), 
			'5' => Invoke5575X(code, p, args), 
			'7' => Invoke5577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke57XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke572XX(code, p, args), 
			'6' => Invoke576XX(code, p, args), 
			'3' => Invoke573XX(code, p, args), 
			'5' => Invoke575XX(code, p, args), 
			'7' => Invoke577XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke572XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5722X(code, p, args), 
			'6' => Invoke5726X(code, p, args), 
			'3' => Invoke5723X(code, p, args), 
			'5' => Invoke5725X(code, p, args), 
			'7' => Invoke5727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke576XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5762X(code, p, args), 
			'6' => Invoke5766X(code, p, args), 
			'3' => Invoke5763X(code, p, args), 
			'5' => Invoke5765X(code, p, args), 
			'7' => Invoke5767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke573XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5732X(code, p, args), 
			'6' => Invoke5736X(code, p, args), 
			'3' => Invoke5733X(code, p, args), 
			'5' => Invoke5735X(code, p, args), 
			'7' => Invoke5737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke575XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5752X(code, p, args), 
			'6' => Invoke5756X(code, p, args), 
			'3' => Invoke5753X(code, p, args), 
			'5' => Invoke5755X(code, p, args), 
			'7' => Invoke5757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke577XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5772X(code, p, args), 
			'6' => Invoke5776X(code, p, args), 
			'3' => Invoke5773X(code, p, args), 
			'5' => Invoke5775X(code, p, args), 
			'7' => Invoke5777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke72XXX(code, p, args), 
			'6' => Invoke76XXX(code, p, args), 
			'3' => Invoke73XXX(code, p, args), 
			'5' => Invoke75XXX(code, p, args), 
			'7' => Invoke77XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke72XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke722XX(code, p, args), 
			'6' => Invoke726XX(code, p, args), 
			'3' => Invoke723XX(code, p, args), 
			'5' => Invoke725XX(code, p, args), 
			'7' => Invoke727XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke722XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7222X(code, p, args), 
			'6' => Invoke7226X(code, p, args), 
			'3' => Invoke7223X(code, p, args), 
			'5' => Invoke7225X(code, p, args), 
			'7' => Invoke7227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke726XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7262X(code, p, args), 
			'6' => Invoke7266X(code, p, args), 
			'3' => Invoke7263X(code, p, args), 
			'5' => Invoke7265X(code, p, args), 
			'7' => Invoke7267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke723XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7232X(code, p, args), 
			'6' => Invoke7236X(code, p, args), 
			'3' => Invoke7233X(code, p, args), 
			'5' => Invoke7235X(code, p, args), 
			'7' => Invoke7237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke725XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7252X(code, p, args), 
			'6' => Invoke7256X(code, p, args), 
			'3' => Invoke7253X(code, p, args), 
			'5' => Invoke7255X(code, p, args), 
			'7' => Invoke7257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke727XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7272X(code, p, args), 
			'6' => Invoke7276X(code, p, args), 
			'3' => Invoke7273X(code, p, args), 
			'5' => Invoke7275X(code, p, args), 
			'7' => Invoke7277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke76XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke762XX(code, p, args), 
			'6' => Invoke766XX(code, p, args), 
			'3' => Invoke763XX(code, p, args), 
			'5' => Invoke765XX(code, p, args), 
			'7' => Invoke767XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke762XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7622X(code, p, args), 
			'6' => Invoke7626X(code, p, args), 
			'3' => Invoke7623X(code, p, args), 
			'5' => Invoke7625X(code, p, args), 
			'7' => Invoke7627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke766XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7662X(code, p, args), 
			'6' => Invoke7666X(code, p, args), 
			'3' => Invoke7663X(code, p, args), 
			'5' => Invoke7665X(code, p, args), 
			'7' => Invoke7667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke763XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7632X(code, p, args), 
			'6' => Invoke7636X(code, p, args), 
			'3' => Invoke7633X(code, p, args), 
			'5' => Invoke7635X(code, p, args), 
			'7' => Invoke7637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke765XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7652X(code, p, args), 
			'6' => Invoke7656X(code, p, args), 
			'3' => Invoke7653X(code, p, args), 
			'5' => Invoke7655X(code, p, args), 
			'7' => Invoke7657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke767XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7672X(code, p, args), 
			'6' => Invoke7676X(code, p, args), 
			'3' => Invoke7673X(code, p, args), 
			'5' => Invoke7675X(code, p, args), 
			'7' => Invoke7677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke73XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke732XX(code, p, args), 
			'6' => Invoke736XX(code, p, args), 
			'3' => Invoke733XX(code, p, args), 
			'5' => Invoke735XX(code, p, args), 
			'7' => Invoke737XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke732XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7322X(code, p, args), 
			'6' => Invoke7326X(code, p, args), 
			'3' => Invoke7323X(code, p, args), 
			'5' => Invoke7325X(code, p, args), 
			'7' => Invoke7327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke736XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7362X(code, p, args), 
			'6' => Invoke7366X(code, p, args), 
			'3' => Invoke7363X(code, p, args), 
			'5' => Invoke7365X(code, p, args), 
			'7' => Invoke7367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke733XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7332X(code, p, args), 
			'6' => Invoke7336X(code, p, args), 
			'3' => Invoke7333X(code, p, args), 
			'5' => Invoke7335X(code, p, args), 
			'7' => Invoke7337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke735XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7352X(code, p, args), 
			'6' => Invoke7356X(code, p, args), 
			'3' => Invoke7353X(code, p, args), 
			'5' => Invoke7355X(code, p, args), 
			'7' => Invoke7357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke737XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7372X(code, p, args), 
			'6' => Invoke7376X(code, p, args), 
			'3' => Invoke7373X(code, p, args), 
			'5' => Invoke7375X(code, p, args), 
			'7' => Invoke7377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke75XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke752XX(code, p, args), 
			'6' => Invoke756XX(code, p, args), 
			'3' => Invoke753XX(code, p, args), 
			'5' => Invoke755XX(code, p, args), 
			'7' => Invoke757XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke752XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7522X(code, p, args), 
			'6' => Invoke7526X(code, p, args), 
			'3' => Invoke7523X(code, p, args), 
			'5' => Invoke7525X(code, p, args), 
			'7' => Invoke7527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke756XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7562X(code, p, args), 
			'6' => Invoke7566X(code, p, args), 
			'3' => Invoke7563X(code, p, args), 
			'5' => Invoke7565X(code, p, args), 
			'7' => Invoke7567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke753XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7532X(code, p, args), 
			'6' => Invoke7536X(code, p, args), 
			'3' => Invoke7533X(code, p, args), 
			'5' => Invoke7535X(code, p, args), 
			'7' => Invoke7537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke755XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7552X(code, p, args), 
			'6' => Invoke7556X(code, p, args), 
			'3' => Invoke7553X(code, p, args), 
			'5' => Invoke7555X(code, p, args), 
			'7' => Invoke7557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke757XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7572X(code, p, args), 
			'6' => Invoke7576X(code, p, args), 
			'3' => Invoke7573X(code, p, args), 
			'5' => Invoke7575X(code, p, args), 
			'7' => Invoke7577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke77XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke772XX(code, p, args), 
			'6' => Invoke776XX(code, p, args), 
			'3' => Invoke773XX(code, p, args), 
			'5' => Invoke775XX(code, p, args), 
			'7' => Invoke777XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke772XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7722X(code, p, args), 
			'6' => Invoke7726X(code, p, args), 
			'3' => Invoke7723X(code, p, args), 
			'5' => Invoke7725X(code, p, args), 
			'7' => Invoke7727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke776XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7762X(code, p, args), 
			'6' => Invoke7766X(code, p, args), 
			'3' => Invoke7763X(code, p, args), 
			'5' => Invoke7765X(code, p, args), 
			'7' => Invoke7767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke773XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7732X(code, p, args), 
			'6' => Invoke7736X(code, p, args), 
			'3' => Invoke7733X(code, p, args), 
			'5' => Invoke7735X(code, p, args), 
			'7' => Invoke7737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke775XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7752X(code, p, args), 
			'6' => Invoke7756X(code, p, args), 
			'3' => Invoke7753X(code, p, args), 
			'5' => Invoke7755X(code, p, args), 
			'7' => Invoke7757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke777XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7772X(code, p, args), 
			'6' => Invoke7776X(code, p, args), 
			'3' => Invoke7773X(code, p, args), 
			'5' => Invoke7775X(code, p, args), 
			'7' => Invoke7777X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, float, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, float, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, float, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, float, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, long, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, long, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, long, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, long, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, double, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, double, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, double, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, double, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, int, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, int, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, int, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, int, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, float, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, float, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, float, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, float, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, long, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, long, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, long, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, long, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, double, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, double, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, double, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, double, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, int, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, int, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, int, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, int, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, float, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, float, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, float, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, float, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, long, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, long, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, long, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, long, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, double, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, double, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, double, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, double, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, int, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, int, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, int, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, int, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, float, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, float, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, float, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, float, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, long, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, long, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, long, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, long, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, double, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, double, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, double, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, double, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, int, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, int, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, int, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, int, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, float, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, float, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, float, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, float, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, long, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, long, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, long, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, long, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, double, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, double, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, double, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, double, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, int, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, int, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, int, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, int, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, float, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, float, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, float, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, long, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, long, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, long, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, long, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, double, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, double, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, double, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, double, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, int, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, int, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, int, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, int, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, float, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, float, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, float, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, float, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, long, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, long, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, long, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, long, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, double, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, double, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, double, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, double, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, int, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, int, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, int, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, int, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, float, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, float, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, float, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, float, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, long, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, long, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, long, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, long, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, double, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, double, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, double, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, double, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, int, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, int, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, int, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, int, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, float, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, float, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, float, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, float, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, long, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, long, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, long, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, long, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, double, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, double, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, double, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, double, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, int, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, int, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, int, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, int, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, float, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, float, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, float, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, float, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, long, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, long, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, long, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, long, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, double, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, double, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, double, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, double, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, int, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, int, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, int, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, int, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, float, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, float, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, float, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, float, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, long, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, long, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, long, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, double, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, double, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, double, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, double, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, int, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, int, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, int, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, int, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, float, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, float, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, float, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, float, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, long, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, long, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, long, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, long, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, double, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, double, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, double, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, double, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, int, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, int, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, int, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, int, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, float, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, float, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, float, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, float, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, long, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, long, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, long, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, long, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, double, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, double, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, double, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, double, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, int, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, int, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, int, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, int, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, float, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, float, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, float, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, float, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, long, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, long, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, long, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, long, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, double, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, double, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, double, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, double, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, int, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, int, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, int, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, int, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, float, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, float, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, float, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, float, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, long, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, long, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, long, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, long, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, double, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, double, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, double, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, double, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, int, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, int, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, int, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, int, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, float, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, float, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, float, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, float, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, long, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, long, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, long, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, long, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, double, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, double, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, double, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke2777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, int, int, int, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, int, int, float, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, int, int, long, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, int, int, double, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, int, int, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, int, float, int, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, int, float, float, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, int, float, long, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, int, float, double, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, int, float, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, int, long, int, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, int, long, float, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, int, long, long, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, int, long, double, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, int, long, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, int, double, int, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, int, double, float, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, int, double, long, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, int, double, double, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, int, double, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, int, IntPtr, int, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, int, IntPtr, float, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, int, IntPtr, long, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, int, IntPtr, double, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, int, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, float, int, int, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, float, int, float, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, float, int, long, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, float, int, double, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, float, int, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, float, float, int, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, float, float, float, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, float, float, long, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, float, float, double, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, float, float, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, float, long, int, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, float, long, float, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, float, long, long, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, float, long, double, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, float, long, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, float, double, int, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, float, double, float, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, float, double, long, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, float, double, double, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, float, double, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, float, IntPtr, int, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, float, IntPtr, float, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, float, IntPtr, long, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, float, IntPtr, double, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, float, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, long, int, int, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, long, int, float, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, long, int, long, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, long, int, double, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, long, int, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, long, float, int, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, long, float, float, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, long, float, long, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, long, float, double, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, long, float, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, long, long, int, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, long, long, float, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, long, long, long, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, long, long, double, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, long, long, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, long, double, int, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, long, double, float, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, long, double, long, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, long, double, double, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, long, double, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, long, IntPtr, int, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, long, IntPtr, float, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, long, IntPtr, long, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, long, IntPtr, double, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, long, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, double, int, int, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, double, int, float, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, double, int, long, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, double, int, double, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, double, int, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, double, float, int, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, double, float, float, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, double, float, long, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, double, float, double, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, double, float, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, double, long, int, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, double, long, float, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, double, long, long, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, double, long, double, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, double, long, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, double, double, int, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, double, double, float, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, double, double, long, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, double, double, double, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, double, double, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, double, IntPtr, int, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, double, IntPtr, float, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, double, IntPtr, long, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, double, IntPtr, double, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, double, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, int, int, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, int, float, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, int, long, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, int, double, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, int, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, float, int, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, float, float, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, float, long, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, float, double, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, float, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, long, int, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, long, float, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, long, long, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, long, double, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, long, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, double, int, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, double, float, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, double, long, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, double, double, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, double, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, IntPtr, int, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, IntPtr, float, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, IntPtr, long, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, IntPtr, double, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, int, int, int, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, int, int, float, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, int, int, long, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, int, int, double, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, int, int, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, int, float, int, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, int, float, float, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, int, float, long, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, int, float, double, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, int, float, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, int, long, int, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, int, long, float, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, int, long, long, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, int, long, double, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, int, long, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, int, double, int, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, int, double, float, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, int, double, long, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, int, double, double, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, int, double, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, int, IntPtr, int, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, int, IntPtr, float, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, int, IntPtr, long, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, int, IntPtr, double, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, int, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, float, int, int, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, float, int, float, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, float, int, long, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, float, int, double, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, float, int, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, float, float, int, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, float, float, float, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, float, float, long, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, float, float, double, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, float, long, int, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, float, long, float, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, float, long, long, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, float, long, double, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, float, long, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, float, double, int, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, float, double, float, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, float, double, long, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, float, double, double, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, float, double, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, int, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, float, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, long, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, double, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, long, int, int, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, long, int, float, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, long, int, long, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, long, int, double, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, long, int, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, long, float, int, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, long, float, float, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, long, float, long, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, long, float, double, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, long, float, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, long, long, int, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, long, long, float, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, long, long, long, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, long, long, double, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, long, long, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, long, double, int, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, long, double, float, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, long, double, long, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, long, double, double, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, long, double, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, long, IntPtr, int, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, long, IntPtr, float, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, long, IntPtr, long, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, long, IntPtr, double, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, long, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, double, int, int, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, double, int, float, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, double, int, long, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, double, int, double, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, double, int, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, double, float, int, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, double, float, float, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, double, float, long, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, double, float, double, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, double, float, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, double, long, int, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, double, long, float, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, double, long, long, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, double, long, double, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, double, long, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, double, double, int, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, double, double, float, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, double, double, long, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, double, double, double, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, double, double, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, double, IntPtr, int, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, double, IntPtr, float, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, double, IntPtr, long, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, double, IntPtr, double, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, double, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, int, int, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, int, float, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, int, long, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, int, double, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, int, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, float, int, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, float, float, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, float, long, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, float, double, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, float, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, long, int, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, long, float, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, long, long, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, long, double, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, long, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, double, int, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, double, float, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, double, long, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, double, double, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, double, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, IntPtr, int, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, IntPtr, float, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, IntPtr, long, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, IntPtr, double, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, int, int, int, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, int, int, float, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, int, int, long, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, int, int, double, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, int, int, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, int, float, int, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, int, float, float, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, int, float, long, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, int, float, double, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, int, float, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, int, long, int, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, int, long, float, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, int, long, long, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, int, long, double, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, int, long, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, int, double, int, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, int, double, float, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, int, double, long, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, int, double, double, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, int, double, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, int, IntPtr, int, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, int, IntPtr, float, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, int, IntPtr, long, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, int, IntPtr, double, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, int, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, float, int, int, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, float, int, float, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, float, int, long, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, float, int, double, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, float, int, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, float, float, int, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, float, float, float, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, float, float, long, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, float, float, double, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, float, float, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, float, long, int, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, float, long, float, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, float, long, long, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, float, long, double, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, float, long, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, float, double, int, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, float, double, float, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, float, double, long, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, float, double, double, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, float, double, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, float, IntPtr, int, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, float, IntPtr, float, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, float, IntPtr, long, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, float, IntPtr, double, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, float, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, long, int, int, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, long, int, float, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, long, int, long, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, long, int, double, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, long, int, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, long, float, int, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, long, float, float, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, long, float, long, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, long, float, double, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, long, float, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, long, long, int, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, long, long, float, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, long, long, long, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, long, long, double, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, long, long, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, long, double, int, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, long, double, float, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, long, double, long, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, long, double, double, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, long, double, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, long, IntPtr, int, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, long, IntPtr, float, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, long, IntPtr, long, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, long, IntPtr, double, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, long, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, double, int, int, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, double, int, float, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, double, int, long, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, double, int, double, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, double, int, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, double, float, int, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, double, float, float, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, double, float, long, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, double, float, double, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, double, float, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, double, long, int, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, double, long, float, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, double, long, long, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, double, long, double, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, double, long, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, double, double, int, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, double, double, float, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, double, double, long, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, double, double, double, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, double, double, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, double, IntPtr, int, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, double, IntPtr, float, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, double, IntPtr, long, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, double, IntPtr, double, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, double, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, int, int, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, int, float, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, int, long, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, int, double, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, int, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, float, int, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, float, float, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, float, long, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, float, double, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, float, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, long, int, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, long, float, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, long, long, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, long, double, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, long, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, double, int, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, double, float, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, double, long, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, double, double, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, double, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, IntPtr, int, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, IntPtr, float, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, IntPtr, long, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, IntPtr, double, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, int, int, int, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, int, int, float, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, int, int, long, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, int, int, double, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, int, int, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, int, float, int, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, int, float, float, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, int, float, long, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, int, float, double, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, int, float, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, int, long, int, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, int, long, float, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, int, long, long, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, int, long, double, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, int, long, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, int, double, int, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, int, double, float, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, int, double, long, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, int, double, double, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, int, double, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, int, IntPtr, int, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, int, IntPtr, float, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, int, IntPtr, long, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, int, IntPtr, double, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, int, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, float, int, int, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, float, int, float, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, float, int, long, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, float, int, double, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, float, int, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, float, float, int, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, float, float, float, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, float, float, long, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, float, float, double, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, float, float, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, float, long, int, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, float, long, float, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, float, long, long, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, float, long, double, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, float, long, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, float, double, int, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, float, double, float, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, float, double, long, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, float, double, double, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, float, double, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, float, IntPtr, int, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, float, IntPtr, float, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, float, IntPtr, long, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, float, IntPtr, double, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, float, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, long, int, int, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, long, int, float, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, long, int, long, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, long, int, double, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, long, int, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, long, float, int, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, long, float, float, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, long, float, long, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, long, float, double, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, long, float, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, long, long, int, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, long, long, float, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, long, long, long, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, long, long, double, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, long, long, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, long, double, int, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, long, double, float, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, long, double, long, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, long, double, double, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, long, double, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, long, IntPtr, int, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, long, IntPtr, float, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, long, IntPtr, long, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, long, IntPtr, double, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, long, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, double, int, int, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, double, int, float, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, double, int, long, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, double, int, double, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, double, int, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, double, float, int, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, double, float, float, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, double, float, long, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, double, float, double, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, double, float, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, double, long, int, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, double, long, float, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, double, long, long, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, double, long, double, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, double, long, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, double, double, int, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, double, double, float, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, double, double, long, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, double, double, double, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, double, double, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, double, IntPtr, int, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, double, IntPtr, float, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, double, IntPtr, long, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, double, IntPtr, double, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, double, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, int, int, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, int, float, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, int, long, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, int, double, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, int, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, float, int, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, float, float, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, float, long, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, float, double, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, float, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, long, int, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, long, float, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, long, long, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, long, double, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, long, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, double, int, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, double, float, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, double, long, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, double, double, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, double, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, IntPtr, int, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, IntPtr, float, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, IntPtr, long, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, IntPtr, double, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, int, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, int, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, int, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, int, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, int, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, float, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, float, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, float, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, float, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, float, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, long, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, long, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, long, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, long, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, long, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, double, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, double, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, double, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, double, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, double, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, IntPtr, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, IntPtr, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, IntPtr, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, IntPtr, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, int, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, int, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, int, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, int, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, int, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, float, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, float, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, float, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, float, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, float, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, long, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, long, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, long, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, long, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, long, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, double, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, double, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, double, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, double, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, double, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, IntPtr, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, IntPtr, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, IntPtr, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, IntPtr, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, int, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, int, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, int, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, int, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, int, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, float, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, float, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, float, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, float, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, float, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, long, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, long, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, long, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, long, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, long, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, double, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, double, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, double, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, double, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, double, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, IntPtr, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, IntPtr, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, IntPtr, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, IntPtr, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, int, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, int, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, int, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, int, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, int, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, float, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, float, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, float, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, float, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, float, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, long, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, long, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, long, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, long, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, long, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, double, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, double, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, double, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, double, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, double, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, IntPtr, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, IntPtr, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, IntPtr, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, IntPtr, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, int, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, int, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, int, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, int, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, float, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, float, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, float, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, float, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, long, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, long, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, long, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, long, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, double, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, double, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, double, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, double, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke6777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, int, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, int, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, int, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, float, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, float, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, float, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, float, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, long, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, long, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, long, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, long, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, double, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, double, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, double, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, double, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, int, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, int, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, int, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, int, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, float, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, float, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, float, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, float, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, long, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, long, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, long, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, long, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, double, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, double, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, double, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, double, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, int, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, int, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, int, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, int, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, float, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, float, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, float, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, float, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, long, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, long, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, long, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, long, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, double, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, double, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, double, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, double, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, int, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, int, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, int, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, int, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, float, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, float, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, float, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, float, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, long, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, long, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, long, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, long, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, double, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, double, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, double, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, double, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, int, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, int, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, int, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, int, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, float, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, float, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, float, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, float, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, long, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, long, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, long, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, long, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, double, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, double, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, double, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, double, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, int, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, int, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, int, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, int, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, float, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, float, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, float, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, long, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, long, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, long, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, long, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, double, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, double, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, double, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, double, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, int, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, int, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, int, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, int, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, float, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, float, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, float, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, float, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, long, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, long, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, long, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, long, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, double, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, double, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, double, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, double, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, int, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, int, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, int, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, int, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, float, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, float, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, float, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, float, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, long, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, long, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, long, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, long, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, double, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, double, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, double, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, double, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, int, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, int, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, int, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, int, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, float, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, float, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, float, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, float, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, long, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, long, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, long, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, long, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, double, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, double, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, double, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, double, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, int, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, int, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, int, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, int, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, float, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, float, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, float, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, float, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, long, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, long, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, long, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, long, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, double, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, double, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, double, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, double, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, int, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, int, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, int, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, int, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, float, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, float, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, float, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, float, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, double, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, double, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, double, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, double, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, int, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, int, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, int, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, int, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, float, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, float, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, float, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, float, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, long, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, long, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, long, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, long, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, double, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, double, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, double, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, double, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, int, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, int, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, int, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, int, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, float, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, float, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, float, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, float, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, long, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, long, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, long, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, long, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, double, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, double, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, double, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, double, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, int, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, int, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, int, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, int, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, float, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, float, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, float, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, float, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, long, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, long, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, long, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, long, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, double, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, double, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, double, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, double, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, int, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, int, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, int, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, int, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, float, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, float, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, float, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, float, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, long, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, long, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, long, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, long, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, double, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, double, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, double, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, double, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, int, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, int, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, int, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, int, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, float, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, float, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, float, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, float, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, long, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, long, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, long, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, long, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, double, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, double, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, double, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke3777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, int, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, int, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, int, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, float, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, float, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, float, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, float, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, long, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, long, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, long, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, long, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, double, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, double, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, double, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, double, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, int, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, int, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, int, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, int, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, float, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, float, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, float, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, float, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, long, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, long, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, long, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, long, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, double, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, double, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, double, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, double, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, int, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, int, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, int, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, int, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, float, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, float, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, float, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, float, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, long, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, long, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, long, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, long, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, double, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, double, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, double, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, double, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, int, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, int, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, int, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, int, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, float, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, float, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, float, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, float, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, long, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, long, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, long, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, long, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, double, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, double, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, double, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, double, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, int, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, int, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, int, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, int, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, float, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, float, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, float, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, float, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, long, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, long, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, long, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, long, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, double, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, double, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, double, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, double, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, int, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, int, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, int, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, int, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, float, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, float, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, float, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, long, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, long, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, long, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, long, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, double, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, double, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, double, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, double, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, int, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, int, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, int, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, int, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, float, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, float, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, float, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, float, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, long, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, long, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, long, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, long, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, double, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, double, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, double, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, double, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, int, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, int, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, int, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, int, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, float, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, float, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, float, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, float, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, long, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, long, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, long, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, long, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, double, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, double, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, double, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, double, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, int, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, int, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, int, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, int, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, float, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, float, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, float, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, float, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, long, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, long, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, long, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, long, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, double, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, double, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, double, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, double, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, int, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, int, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, int, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, int, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, float, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, float, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, float, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, float, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, long, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, long, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, long, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, long, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, double, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, double, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, double, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, double, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, int, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, int, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, int, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, int, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, float, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, float, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, float, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, float, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, long, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, long, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, long, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, double, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, double, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, double, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, double, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, int, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, int, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, int, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, int, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, float, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, float, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, float, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, float, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, long, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, long, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, long, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, long, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, double, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, double, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, double, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, double, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, int, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, int, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, int, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, int, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, float, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, float, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, float, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, float, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, long, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, long, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, long, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, long, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, double, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, double, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, double, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, double, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, int, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, int, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, int, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, int, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, float, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, float, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, float, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, float, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, long, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, long, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, long, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, long, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, double, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, double, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, double, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, double, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, int, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, int, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, int, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, int, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, float, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, float, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, float, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, float, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, long, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, long, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, long, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, long, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, double, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, double, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, double, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, double, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, int, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, int, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, int, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, int, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, float, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, float, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, float, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, float, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, long, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, long, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, long, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, long, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke5777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke7777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4]), 
			_ => -1, 
		};
	}
}
