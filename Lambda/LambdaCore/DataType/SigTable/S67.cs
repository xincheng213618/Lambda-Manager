using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S67
{
	public static int Invoke7(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke72XXXX(code, p, args), 
			'6' => Invoke76XXXX(code, p, args), 
			'3' => Invoke73XXXX(code, p, args), 
			'5' => Invoke75XXXX(code, p, args), 
			'7' => Invoke77XXXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke72XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke722XXX(code, p, args), 
			'6' => Invoke726XXX(code, p, args), 
			'3' => Invoke723XXX(code, p, args), 
			'5' => Invoke725XXX(code, p, args), 
			'7' => Invoke727XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke722XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7222XX(code, p, args), 
			'6' => Invoke7226XX(code, p, args), 
			'3' => Invoke7223XX(code, p, args), 
			'5' => Invoke7225XX(code, p, args), 
			'7' => Invoke7227XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7222XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72222X(code, p, args), 
			'6' => Invoke72226X(code, p, args), 
			'3' => Invoke72223X(code, p, args), 
			'5' => Invoke72225X(code, p, args), 
			'7' => Invoke72227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7226XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72262X(code, p, args), 
			'6' => Invoke72266X(code, p, args), 
			'3' => Invoke72263X(code, p, args), 
			'5' => Invoke72265X(code, p, args), 
			'7' => Invoke72267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7223XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72232X(code, p, args), 
			'6' => Invoke72236X(code, p, args), 
			'3' => Invoke72233X(code, p, args), 
			'5' => Invoke72235X(code, p, args), 
			'7' => Invoke72237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7225XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72252X(code, p, args), 
			'6' => Invoke72256X(code, p, args), 
			'3' => Invoke72253X(code, p, args), 
			'5' => Invoke72255X(code, p, args), 
			'7' => Invoke72257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7227XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72272X(code, p, args), 
			'6' => Invoke72276X(code, p, args), 
			'3' => Invoke72273X(code, p, args), 
			'5' => Invoke72275X(code, p, args), 
			'7' => Invoke72277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke726XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7262XX(code, p, args), 
			'6' => Invoke7266XX(code, p, args), 
			'3' => Invoke7263XX(code, p, args), 
			'5' => Invoke7265XX(code, p, args), 
			'7' => Invoke7267XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7262XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72622X(code, p, args), 
			'6' => Invoke72626X(code, p, args), 
			'3' => Invoke72623X(code, p, args), 
			'5' => Invoke72625X(code, p, args), 
			'7' => Invoke72627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7266XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72662X(code, p, args), 
			'6' => Invoke72666X(code, p, args), 
			'3' => Invoke72663X(code, p, args), 
			'5' => Invoke72665X(code, p, args), 
			'7' => Invoke72667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7263XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72632X(code, p, args), 
			'6' => Invoke72636X(code, p, args), 
			'3' => Invoke72633X(code, p, args), 
			'5' => Invoke72635X(code, p, args), 
			'7' => Invoke72637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7265XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72652X(code, p, args), 
			'6' => Invoke72656X(code, p, args), 
			'3' => Invoke72653X(code, p, args), 
			'5' => Invoke72655X(code, p, args), 
			'7' => Invoke72657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7267XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72672X(code, p, args), 
			'6' => Invoke72676X(code, p, args), 
			'3' => Invoke72673X(code, p, args), 
			'5' => Invoke72675X(code, p, args), 
			'7' => Invoke72677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke723XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7232XX(code, p, args), 
			'6' => Invoke7236XX(code, p, args), 
			'3' => Invoke7233XX(code, p, args), 
			'5' => Invoke7235XX(code, p, args), 
			'7' => Invoke7237XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7232XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72322X(code, p, args), 
			'6' => Invoke72326X(code, p, args), 
			'3' => Invoke72323X(code, p, args), 
			'5' => Invoke72325X(code, p, args), 
			'7' => Invoke72327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7236XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72362X(code, p, args), 
			'6' => Invoke72366X(code, p, args), 
			'3' => Invoke72363X(code, p, args), 
			'5' => Invoke72365X(code, p, args), 
			'7' => Invoke72367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7233XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72332X(code, p, args), 
			'6' => Invoke72336X(code, p, args), 
			'3' => Invoke72333X(code, p, args), 
			'5' => Invoke72335X(code, p, args), 
			'7' => Invoke72337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7235XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72352X(code, p, args), 
			'6' => Invoke72356X(code, p, args), 
			'3' => Invoke72353X(code, p, args), 
			'5' => Invoke72355X(code, p, args), 
			'7' => Invoke72357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7237XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72372X(code, p, args), 
			'6' => Invoke72376X(code, p, args), 
			'3' => Invoke72373X(code, p, args), 
			'5' => Invoke72375X(code, p, args), 
			'7' => Invoke72377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke725XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7252XX(code, p, args), 
			'6' => Invoke7256XX(code, p, args), 
			'3' => Invoke7253XX(code, p, args), 
			'5' => Invoke7255XX(code, p, args), 
			'7' => Invoke7257XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7252XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72522X(code, p, args), 
			'6' => Invoke72526X(code, p, args), 
			'3' => Invoke72523X(code, p, args), 
			'5' => Invoke72525X(code, p, args), 
			'7' => Invoke72527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7256XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72562X(code, p, args), 
			'6' => Invoke72566X(code, p, args), 
			'3' => Invoke72563X(code, p, args), 
			'5' => Invoke72565X(code, p, args), 
			'7' => Invoke72567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7253XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72532X(code, p, args), 
			'6' => Invoke72536X(code, p, args), 
			'3' => Invoke72533X(code, p, args), 
			'5' => Invoke72535X(code, p, args), 
			'7' => Invoke72537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7255XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72552X(code, p, args), 
			'6' => Invoke72556X(code, p, args), 
			'3' => Invoke72553X(code, p, args), 
			'5' => Invoke72555X(code, p, args), 
			'7' => Invoke72557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7257XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72572X(code, p, args), 
			'6' => Invoke72576X(code, p, args), 
			'3' => Invoke72573X(code, p, args), 
			'5' => Invoke72575X(code, p, args), 
			'7' => Invoke72577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke727XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7272XX(code, p, args), 
			'6' => Invoke7276XX(code, p, args), 
			'3' => Invoke7273XX(code, p, args), 
			'5' => Invoke7275XX(code, p, args), 
			'7' => Invoke7277XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7272XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72722X(code, p, args), 
			'6' => Invoke72726X(code, p, args), 
			'3' => Invoke72723X(code, p, args), 
			'5' => Invoke72725X(code, p, args), 
			'7' => Invoke72727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7276XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72762X(code, p, args), 
			'6' => Invoke72766X(code, p, args), 
			'3' => Invoke72763X(code, p, args), 
			'5' => Invoke72765X(code, p, args), 
			'7' => Invoke72767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7273XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72732X(code, p, args), 
			'6' => Invoke72736X(code, p, args), 
			'3' => Invoke72733X(code, p, args), 
			'5' => Invoke72735X(code, p, args), 
			'7' => Invoke72737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7275XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72752X(code, p, args), 
			'6' => Invoke72756X(code, p, args), 
			'3' => Invoke72753X(code, p, args), 
			'5' => Invoke72755X(code, p, args), 
			'7' => Invoke72757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7277XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke72772X(code, p, args), 
			'6' => Invoke72776X(code, p, args), 
			'3' => Invoke72773X(code, p, args), 
			'5' => Invoke72775X(code, p, args), 
			'7' => Invoke72777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke76XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke762XXX(code, p, args), 
			'6' => Invoke766XXX(code, p, args), 
			'3' => Invoke763XXX(code, p, args), 
			'5' => Invoke765XXX(code, p, args), 
			'7' => Invoke767XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke762XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7622XX(code, p, args), 
			'6' => Invoke7626XX(code, p, args), 
			'3' => Invoke7623XX(code, p, args), 
			'5' => Invoke7625XX(code, p, args), 
			'7' => Invoke7627XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7622XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76222X(code, p, args), 
			'6' => Invoke76226X(code, p, args), 
			'3' => Invoke76223X(code, p, args), 
			'5' => Invoke76225X(code, p, args), 
			'7' => Invoke76227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7626XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76262X(code, p, args), 
			'6' => Invoke76266X(code, p, args), 
			'3' => Invoke76263X(code, p, args), 
			'5' => Invoke76265X(code, p, args), 
			'7' => Invoke76267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7623XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76232X(code, p, args), 
			'6' => Invoke76236X(code, p, args), 
			'3' => Invoke76233X(code, p, args), 
			'5' => Invoke76235X(code, p, args), 
			'7' => Invoke76237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7625XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76252X(code, p, args), 
			'6' => Invoke76256X(code, p, args), 
			'3' => Invoke76253X(code, p, args), 
			'5' => Invoke76255X(code, p, args), 
			'7' => Invoke76257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7627XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76272X(code, p, args), 
			'6' => Invoke76276X(code, p, args), 
			'3' => Invoke76273X(code, p, args), 
			'5' => Invoke76275X(code, p, args), 
			'7' => Invoke76277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke766XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7662XX(code, p, args), 
			'6' => Invoke7666XX(code, p, args), 
			'3' => Invoke7663XX(code, p, args), 
			'5' => Invoke7665XX(code, p, args), 
			'7' => Invoke7667XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7662XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76622X(code, p, args), 
			'6' => Invoke76626X(code, p, args), 
			'3' => Invoke76623X(code, p, args), 
			'5' => Invoke76625X(code, p, args), 
			'7' => Invoke76627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7666XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76662X(code, p, args), 
			'6' => Invoke76666X(code, p, args), 
			'3' => Invoke76663X(code, p, args), 
			'5' => Invoke76665X(code, p, args), 
			'7' => Invoke76667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7663XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76632X(code, p, args), 
			'6' => Invoke76636X(code, p, args), 
			'3' => Invoke76633X(code, p, args), 
			'5' => Invoke76635X(code, p, args), 
			'7' => Invoke76637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7665XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76652X(code, p, args), 
			'6' => Invoke76656X(code, p, args), 
			'3' => Invoke76653X(code, p, args), 
			'5' => Invoke76655X(code, p, args), 
			'7' => Invoke76657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7667XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76672X(code, p, args), 
			'6' => Invoke76676X(code, p, args), 
			'3' => Invoke76673X(code, p, args), 
			'5' => Invoke76675X(code, p, args), 
			'7' => Invoke76677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke763XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7632XX(code, p, args), 
			'6' => Invoke7636XX(code, p, args), 
			'3' => Invoke7633XX(code, p, args), 
			'5' => Invoke7635XX(code, p, args), 
			'7' => Invoke7637XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7632XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76322X(code, p, args), 
			'6' => Invoke76326X(code, p, args), 
			'3' => Invoke76323X(code, p, args), 
			'5' => Invoke76325X(code, p, args), 
			'7' => Invoke76327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7636XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76362X(code, p, args), 
			'6' => Invoke76366X(code, p, args), 
			'3' => Invoke76363X(code, p, args), 
			'5' => Invoke76365X(code, p, args), 
			'7' => Invoke76367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7633XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76332X(code, p, args), 
			'6' => Invoke76336X(code, p, args), 
			'3' => Invoke76333X(code, p, args), 
			'5' => Invoke76335X(code, p, args), 
			'7' => Invoke76337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7635XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76352X(code, p, args), 
			'6' => Invoke76356X(code, p, args), 
			'3' => Invoke76353X(code, p, args), 
			'5' => Invoke76355X(code, p, args), 
			'7' => Invoke76357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7637XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76372X(code, p, args), 
			'6' => Invoke76376X(code, p, args), 
			'3' => Invoke76373X(code, p, args), 
			'5' => Invoke76375X(code, p, args), 
			'7' => Invoke76377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke765XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7652XX(code, p, args), 
			'6' => Invoke7656XX(code, p, args), 
			'3' => Invoke7653XX(code, p, args), 
			'5' => Invoke7655XX(code, p, args), 
			'7' => Invoke7657XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7652XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76522X(code, p, args), 
			'6' => Invoke76526X(code, p, args), 
			'3' => Invoke76523X(code, p, args), 
			'5' => Invoke76525X(code, p, args), 
			'7' => Invoke76527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7656XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76562X(code, p, args), 
			'6' => Invoke76566X(code, p, args), 
			'3' => Invoke76563X(code, p, args), 
			'5' => Invoke76565X(code, p, args), 
			'7' => Invoke76567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7653XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76532X(code, p, args), 
			'6' => Invoke76536X(code, p, args), 
			'3' => Invoke76533X(code, p, args), 
			'5' => Invoke76535X(code, p, args), 
			'7' => Invoke76537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7655XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76552X(code, p, args), 
			'6' => Invoke76556X(code, p, args), 
			'3' => Invoke76553X(code, p, args), 
			'5' => Invoke76555X(code, p, args), 
			'7' => Invoke76557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7657XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76572X(code, p, args), 
			'6' => Invoke76576X(code, p, args), 
			'3' => Invoke76573X(code, p, args), 
			'5' => Invoke76575X(code, p, args), 
			'7' => Invoke76577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke767XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7672XX(code, p, args), 
			'6' => Invoke7676XX(code, p, args), 
			'3' => Invoke7673XX(code, p, args), 
			'5' => Invoke7675XX(code, p, args), 
			'7' => Invoke7677XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7672XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76722X(code, p, args), 
			'6' => Invoke76726X(code, p, args), 
			'3' => Invoke76723X(code, p, args), 
			'5' => Invoke76725X(code, p, args), 
			'7' => Invoke76727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7676XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76762X(code, p, args), 
			'6' => Invoke76766X(code, p, args), 
			'3' => Invoke76763X(code, p, args), 
			'5' => Invoke76765X(code, p, args), 
			'7' => Invoke76767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7673XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76732X(code, p, args), 
			'6' => Invoke76736X(code, p, args), 
			'3' => Invoke76733X(code, p, args), 
			'5' => Invoke76735X(code, p, args), 
			'7' => Invoke76737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7675XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76752X(code, p, args), 
			'6' => Invoke76756X(code, p, args), 
			'3' => Invoke76753X(code, p, args), 
			'5' => Invoke76755X(code, p, args), 
			'7' => Invoke76757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7677XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke76772X(code, p, args), 
			'6' => Invoke76776X(code, p, args), 
			'3' => Invoke76773X(code, p, args), 
			'5' => Invoke76775X(code, p, args), 
			'7' => Invoke76777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke73XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke732XXX(code, p, args), 
			'6' => Invoke736XXX(code, p, args), 
			'3' => Invoke733XXX(code, p, args), 
			'5' => Invoke735XXX(code, p, args), 
			'7' => Invoke737XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke732XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7322XX(code, p, args), 
			'6' => Invoke7326XX(code, p, args), 
			'3' => Invoke7323XX(code, p, args), 
			'5' => Invoke7325XX(code, p, args), 
			'7' => Invoke7327XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7322XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73222X(code, p, args), 
			'6' => Invoke73226X(code, p, args), 
			'3' => Invoke73223X(code, p, args), 
			'5' => Invoke73225X(code, p, args), 
			'7' => Invoke73227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7326XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73262X(code, p, args), 
			'6' => Invoke73266X(code, p, args), 
			'3' => Invoke73263X(code, p, args), 
			'5' => Invoke73265X(code, p, args), 
			'7' => Invoke73267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7323XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73232X(code, p, args), 
			'6' => Invoke73236X(code, p, args), 
			'3' => Invoke73233X(code, p, args), 
			'5' => Invoke73235X(code, p, args), 
			'7' => Invoke73237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7325XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73252X(code, p, args), 
			'6' => Invoke73256X(code, p, args), 
			'3' => Invoke73253X(code, p, args), 
			'5' => Invoke73255X(code, p, args), 
			'7' => Invoke73257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7327XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73272X(code, p, args), 
			'6' => Invoke73276X(code, p, args), 
			'3' => Invoke73273X(code, p, args), 
			'5' => Invoke73275X(code, p, args), 
			'7' => Invoke73277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke736XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7362XX(code, p, args), 
			'6' => Invoke7366XX(code, p, args), 
			'3' => Invoke7363XX(code, p, args), 
			'5' => Invoke7365XX(code, p, args), 
			'7' => Invoke7367XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7362XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73622X(code, p, args), 
			'6' => Invoke73626X(code, p, args), 
			'3' => Invoke73623X(code, p, args), 
			'5' => Invoke73625X(code, p, args), 
			'7' => Invoke73627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7366XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73662X(code, p, args), 
			'6' => Invoke73666X(code, p, args), 
			'3' => Invoke73663X(code, p, args), 
			'5' => Invoke73665X(code, p, args), 
			'7' => Invoke73667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7363XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73632X(code, p, args), 
			'6' => Invoke73636X(code, p, args), 
			'3' => Invoke73633X(code, p, args), 
			'5' => Invoke73635X(code, p, args), 
			'7' => Invoke73637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7365XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73652X(code, p, args), 
			'6' => Invoke73656X(code, p, args), 
			'3' => Invoke73653X(code, p, args), 
			'5' => Invoke73655X(code, p, args), 
			'7' => Invoke73657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7367XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73672X(code, p, args), 
			'6' => Invoke73676X(code, p, args), 
			'3' => Invoke73673X(code, p, args), 
			'5' => Invoke73675X(code, p, args), 
			'7' => Invoke73677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke733XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7332XX(code, p, args), 
			'6' => Invoke7336XX(code, p, args), 
			'3' => Invoke7333XX(code, p, args), 
			'5' => Invoke7335XX(code, p, args), 
			'7' => Invoke7337XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7332XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73322X(code, p, args), 
			'6' => Invoke73326X(code, p, args), 
			'3' => Invoke73323X(code, p, args), 
			'5' => Invoke73325X(code, p, args), 
			'7' => Invoke73327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7336XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73362X(code, p, args), 
			'6' => Invoke73366X(code, p, args), 
			'3' => Invoke73363X(code, p, args), 
			'5' => Invoke73365X(code, p, args), 
			'7' => Invoke73367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7333XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73332X(code, p, args), 
			'6' => Invoke73336X(code, p, args), 
			'3' => Invoke73333X(code, p, args), 
			'5' => Invoke73335X(code, p, args), 
			'7' => Invoke73337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7335XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73352X(code, p, args), 
			'6' => Invoke73356X(code, p, args), 
			'3' => Invoke73353X(code, p, args), 
			'5' => Invoke73355X(code, p, args), 
			'7' => Invoke73357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7337XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73372X(code, p, args), 
			'6' => Invoke73376X(code, p, args), 
			'3' => Invoke73373X(code, p, args), 
			'5' => Invoke73375X(code, p, args), 
			'7' => Invoke73377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke735XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7352XX(code, p, args), 
			'6' => Invoke7356XX(code, p, args), 
			'3' => Invoke7353XX(code, p, args), 
			'5' => Invoke7355XX(code, p, args), 
			'7' => Invoke7357XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7352XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73522X(code, p, args), 
			'6' => Invoke73526X(code, p, args), 
			'3' => Invoke73523X(code, p, args), 
			'5' => Invoke73525X(code, p, args), 
			'7' => Invoke73527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7356XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73562X(code, p, args), 
			'6' => Invoke73566X(code, p, args), 
			'3' => Invoke73563X(code, p, args), 
			'5' => Invoke73565X(code, p, args), 
			'7' => Invoke73567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7353XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73532X(code, p, args), 
			'6' => Invoke73536X(code, p, args), 
			'3' => Invoke73533X(code, p, args), 
			'5' => Invoke73535X(code, p, args), 
			'7' => Invoke73537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7355XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73552X(code, p, args), 
			'6' => Invoke73556X(code, p, args), 
			'3' => Invoke73553X(code, p, args), 
			'5' => Invoke73555X(code, p, args), 
			'7' => Invoke73557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7357XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73572X(code, p, args), 
			'6' => Invoke73576X(code, p, args), 
			'3' => Invoke73573X(code, p, args), 
			'5' => Invoke73575X(code, p, args), 
			'7' => Invoke73577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke737XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7372XX(code, p, args), 
			'6' => Invoke7376XX(code, p, args), 
			'3' => Invoke7373XX(code, p, args), 
			'5' => Invoke7375XX(code, p, args), 
			'7' => Invoke7377XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7372XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73722X(code, p, args), 
			'6' => Invoke73726X(code, p, args), 
			'3' => Invoke73723X(code, p, args), 
			'5' => Invoke73725X(code, p, args), 
			'7' => Invoke73727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7376XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73762X(code, p, args), 
			'6' => Invoke73766X(code, p, args), 
			'3' => Invoke73763X(code, p, args), 
			'5' => Invoke73765X(code, p, args), 
			'7' => Invoke73767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7373XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73732X(code, p, args), 
			'6' => Invoke73736X(code, p, args), 
			'3' => Invoke73733X(code, p, args), 
			'5' => Invoke73735X(code, p, args), 
			'7' => Invoke73737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7375XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73752X(code, p, args), 
			'6' => Invoke73756X(code, p, args), 
			'3' => Invoke73753X(code, p, args), 
			'5' => Invoke73755X(code, p, args), 
			'7' => Invoke73757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7377XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke73772X(code, p, args), 
			'6' => Invoke73776X(code, p, args), 
			'3' => Invoke73773X(code, p, args), 
			'5' => Invoke73775X(code, p, args), 
			'7' => Invoke73777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke75XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke752XXX(code, p, args), 
			'6' => Invoke756XXX(code, p, args), 
			'3' => Invoke753XXX(code, p, args), 
			'5' => Invoke755XXX(code, p, args), 
			'7' => Invoke757XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke752XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7522XX(code, p, args), 
			'6' => Invoke7526XX(code, p, args), 
			'3' => Invoke7523XX(code, p, args), 
			'5' => Invoke7525XX(code, p, args), 
			'7' => Invoke7527XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7522XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75222X(code, p, args), 
			'6' => Invoke75226X(code, p, args), 
			'3' => Invoke75223X(code, p, args), 
			'5' => Invoke75225X(code, p, args), 
			'7' => Invoke75227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7526XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75262X(code, p, args), 
			'6' => Invoke75266X(code, p, args), 
			'3' => Invoke75263X(code, p, args), 
			'5' => Invoke75265X(code, p, args), 
			'7' => Invoke75267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7523XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75232X(code, p, args), 
			'6' => Invoke75236X(code, p, args), 
			'3' => Invoke75233X(code, p, args), 
			'5' => Invoke75235X(code, p, args), 
			'7' => Invoke75237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7525XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75252X(code, p, args), 
			'6' => Invoke75256X(code, p, args), 
			'3' => Invoke75253X(code, p, args), 
			'5' => Invoke75255X(code, p, args), 
			'7' => Invoke75257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7527XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75272X(code, p, args), 
			'6' => Invoke75276X(code, p, args), 
			'3' => Invoke75273X(code, p, args), 
			'5' => Invoke75275X(code, p, args), 
			'7' => Invoke75277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke756XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7562XX(code, p, args), 
			'6' => Invoke7566XX(code, p, args), 
			'3' => Invoke7563XX(code, p, args), 
			'5' => Invoke7565XX(code, p, args), 
			'7' => Invoke7567XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7562XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75622X(code, p, args), 
			'6' => Invoke75626X(code, p, args), 
			'3' => Invoke75623X(code, p, args), 
			'5' => Invoke75625X(code, p, args), 
			'7' => Invoke75627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7566XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75662X(code, p, args), 
			'6' => Invoke75666X(code, p, args), 
			'3' => Invoke75663X(code, p, args), 
			'5' => Invoke75665X(code, p, args), 
			'7' => Invoke75667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7563XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75632X(code, p, args), 
			'6' => Invoke75636X(code, p, args), 
			'3' => Invoke75633X(code, p, args), 
			'5' => Invoke75635X(code, p, args), 
			'7' => Invoke75637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7565XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75652X(code, p, args), 
			'6' => Invoke75656X(code, p, args), 
			'3' => Invoke75653X(code, p, args), 
			'5' => Invoke75655X(code, p, args), 
			'7' => Invoke75657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7567XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75672X(code, p, args), 
			'6' => Invoke75676X(code, p, args), 
			'3' => Invoke75673X(code, p, args), 
			'5' => Invoke75675X(code, p, args), 
			'7' => Invoke75677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke753XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7532XX(code, p, args), 
			'6' => Invoke7536XX(code, p, args), 
			'3' => Invoke7533XX(code, p, args), 
			'5' => Invoke7535XX(code, p, args), 
			'7' => Invoke7537XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7532XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75322X(code, p, args), 
			'6' => Invoke75326X(code, p, args), 
			'3' => Invoke75323X(code, p, args), 
			'5' => Invoke75325X(code, p, args), 
			'7' => Invoke75327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7536XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75362X(code, p, args), 
			'6' => Invoke75366X(code, p, args), 
			'3' => Invoke75363X(code, p, args), 
			'5' => Invoke75365X(code, p, args), 
			'7' => Invoke75367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7533XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75332X(code, p, args), 
			'6' => Invoke75336X(code, p, args), 
			'3' => Invoke75333X(code, p, args), 
			'5' => Invoke75335X(code, p, args), 
			'7' => Invoke75337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7535XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75352X(code, p, args), 
			'6' => Invoke75356X(code, p, args), 
			'3' => Invoke75353X(code, p, args), 
			'5' => Invoke75355X(code, p, args), 
			'7' => Invoke75357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7537XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75372X(code, p, args), 
			'6' => Invoke75376X(code, p, args), 
			'3' => Invoke75373X(code, p, args), 
			'5' => Invoke75375X(code, p, args), 
			'7' => Invoke75377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke755XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7552XX(code, p, args), 
			'6' => Invoke7556XX(code, p, args), 
			'3' => Invoke7553XX(code, p, args), 
			'5' => Invoke7555XX(code, p, args), 
			'7' => Invoke7557XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7552XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75522X(code, p, args), 
			'6' => Invoke75526X(code, p, args), 
			'3' => Invoke75523X(code, p, args), 
			'5' => Invoke75525X(code, p, args), 
			'7' => Invoke75527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7556XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75562X(code, p, args), 
			'6' => Invoke75566X(code, p, args), 
			'3' => Invoke75563X(code, p, args), 
			'5' => Invoke75565X(code, p, args), 
			'7' => Invoke75567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7553XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75532X(code, p, args), 
			'6' => Invoke75536X(code, p, args), 
			'3' => Invoke75533X(code, p, args), 
			'5' => Invoke75535X(code, p, args), 
			'7' => Invoke75537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7555XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75552X(code, p, args), 
			'6' => Invoke75556X(code, p, args), 
			'3' => Invoke75553X(code, p, args), 
			'5' => Invoke75555X(code, p, args), 
			'7' => Invoke75557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7557XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75572X(code, p, args), 
			'6' => Invoke75576X(code, p, args), 
			'3' => Invoke75573X(code, p, args), 
			'5' => Invoke75575X(code, p, args), 
			'7' => Invoke75577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke757XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7572XX(code, p, args), 
			'6' => Invoke7576XX(code, p, args), 
			'3' => Invoke7573XX(code, p, args), 
			'5' => Invoke7575XX(code, p, args), 
			'7' => Invoke7577XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7572XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75722X(code, p, args), 
			'6' => Invoke75726X(code, p, args), 
			'3' => Invoke75723X(code, p, args), 
			'5' => Invoke75725X(code, p, args), 
			'7' => Invoke75727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7576XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75762X(code, p, args), 
			'6' => Invoke75766X(code, p, args), 
			'3' => Invoke75763X(code, p, args), 
			'5' => Invoke75765X(code, p, args), 
			'7' => Invoke75767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7573XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75732X(code, p, args), 
			'6' => Invoke75736X(code, p, args), 
			'3' => Invoke75733X(code, p, args), 
			'5' => Invoke75735X(code, p, args), 
			'7' => Invoke75737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7575XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75752X(code, p, args), 
			'6' => Invoke75756X(code, p, args), 
			'3' => Invoke75753X(code, p, args), 
			'5' => Invoke75755X(code, p, args), 
			'7' => Invoke75757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7577XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke75772X(code, p, args), 
			'6' => Invoke75776X(code, p, args), 
			'3' => Invoke75773X(code, p, args), 
			'5' => Invoke75775X(code, p, args), 
			'7' => Invoke75777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke77XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke772XXX(code, p, args), 
			'6' => Invoke776XXX(code, p, args), 
			'3' => Invoke773XXX(code, p, args), 
			'5' => Invoke775XXX(code, p, args), 
			'7' => Invoke777XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke772XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7722XX(code, p, args), 
			'6' => Invoke7726XX(code, p, args), 
			'3' => Invoke7723XX(code, p, args), 
			'5' => Invoke7725XX(code, p, args), 
			'7' => Invoke7727XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7722XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77222X(code, p, args), 
			'6' => Invoke77226X(code, p, args), 
			'3' => Invoke77223X(code, p, args), 
			'5' => Invoke77225X(code, p, args), 
			'7' => Invoke77227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7726XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77262X(code, p, args), 
			'6' => Invoke77266X(code, p, args), 
			'3' => Invoke77263X(code, p, args), 
			'5' => Invoke77265X(code, p, args), 
			'7' => Invoke77267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7723XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77232X(code, p, args), 
			'6' => Invoke77236X(code, p, args), 
			'3' => Invoke77233X(code, p, args), 
			'5' => Invoke77235X(code, p, args), 
			'7' => Invoke77237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7725XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77252X(code, p, args), 
			'6' => Invoke77256X(code, p, args), 
			'3' => Invoke77253X(code, p, args), 
			'5' => Invoke77255X(code, p, args), 
			'7' => Invoke77257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7727XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77272X(code, p, args), 
			'6' => Invoke77276X(code, p, args), 
			'3' => Invoke77273X(code, p, args), 
			'5' => Invoke77275X(code, p, args), 
			'7' => Invoke77277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke776XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7762XX(code, p, args), 
			'6' => Invoke7766XX(code, p, args), 
			'3' => Invoke7763XX(code, p, args), 
			'5' => Invoke7765XX(code, p, args), 
			'7' => Invoke7767XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7762XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77622X(code, p, args), 
			'6' => Invoke77626X(code, p, args), 
			'3' => Invoke77623X(code, p, args), 
			'5' => Invoke77625X(code, p, args), 
			'7' => Invoke77627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7766XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77662X(code, p, args), 
			'6' => Invoke77666X(code, p, args), 
			'3' => Invoke77663X(code, p, args), 
			'5' => Invoke77665X(code, p, args), 
			'7' => Invoke77667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7763XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77632X(code, p, args), 
			'6' => Invoke77636X(code, p, args), 
			'3' => Invoke77633X(code, p, args), 
			'5' => Invoke77635X(code, p, args), 
			'7' => Invoke77637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7765XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77652X(code, p, args), 
			'6' => Invoke77656X(code, p, args), 
			'3' => Invoke77653X(code, p, args), 
			'5' => Invoke77655X(code, p, args), 
			'7' => Invoke77657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7767XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77672X(code, p, args), 
			'6' => Invoke77676X(code, p, args), 
			'3' => Invoke77673X(code, p, args), 
			'5' => Invoke77675X(code, p, args), 
			'7' => Invoke77677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke773XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7732XX(code, p, args), 
			'6' => Invoke7736XX(code, p, args), 
			'3' => Invoke7733XX(code, p, args), 
			'5' => Invoke7735XX(code, p, args), 
			'7' => Invoke7737XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7732XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77322X(code, p, args), 
			'6' => Invoke77326X(code, p, args), 
			'3' => Invoke77323X(code, p, args), 
			'5' => Invoke77325X(code, p, args), 
			'7' => Invoke77327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7736XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77362X(code, p, args), 
			'6' => Invoke77366X(code, p, args), 
			'3' => Invoke77363X(code, p, args), 
			'5' => Invoke77365X(code, p, args), 
			'7' => Invoke77367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7733XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77332X(code, p, args), 
			'6' => Invoke77336X(code, p, args), 
			'3' => Invoke77333X(code, p, args), 
			'5' => Invoke77335X(code, p, args), 
			'7' => Invoke77337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7735XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77352X(code, p, args), 
			'6' => Invoke77356X(code, p, args), 
			'3' => Invoke77353X(code, p, args), 
			'5' => Invoke77355X(code, p, args), 
			'7' => Invoke77357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7737XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77372X(code, p, args), 
			'6' => Invoke77376X(code, p, args), 
			'3' => Invoke77373X(code, p, args), 
			'5' => Invoke77375X(code, p, args), 
			'7' => Invoke77377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke775XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7752XX(code, p, args), 
			'6' => Invoke7756XX(code, p, args), 
			'3' => Invoke7753XX(code, p, args), 
			'5' => Invoke7755XX(code, p, args), 
			'7' => Invoke7757XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7752XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77522X(code, p, args), 
			'6' => Invoke77526X(code, p, args), 
			'3' => Invoke77523X(code, p, args), 
			'5' => Invoke77525X(code, p, args), 
			'7' => Invoke77527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7756XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77562X(code, p, args), 
			'6' => Invoke77566X(code, p, args), 
			'3' => Invoke77563X(code, p, args), 
			'5' => Invoke77565X(code, p, args), 
			'7' => Invoke77567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7753XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77532X(code, p, args), 
			'6' => Invoke77536X(code, p, args), 
			'3' => Invoke77533X(code, p, args), 
			'5' => Invoke77535X(code, p, args), 
			'7' => Invoke77537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7755XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77552X(code, p, args), 
			'6' => Invoke77556X(code, p, args), 
			'3' => Invoke77553X(code, p, args), 
			'5' => Invoke77555X(code, p, args), 
			'7' => Invoke77557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7757XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77572X(code, p, args), 
			'6' => Invoke77576X(code, p, args), 
			'3' => Invoke77573X(code, p, args), 
			'5' => Invoke77575X(code, p, args), 
			'7' => Invoke77577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke777XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke7772XX(code, p, args), 
			'6' => Invoke7776XX(code, p, args), 
			'3' => Invoke7773XX(code, p, args), 
			'5' => Invoke7775XX(code, p, args), 
			'7' => Invoke7777XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7772XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77722X(code, p, args), 
			'6' => Invoke77726X(code, p, args), 
			'3' => Invoke77723X(code, p, args), 
			'5' => Invoke77725X(code, p, args), 
			'7' => Invoke77727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7776XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77762X(code, p, args), 
			'6' => Invoke77766X(code, p, args), 
			'3' => Invoke77763X(code, p, args), 
			'5' => Invoke77765X(code, p, args), 
			'7' => Invoke77767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7773XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77732X(code, p, args), 
			'6' => Invoke77736X(code, p, args), 
			'3' => Invoke77733X(code, p, args), 
			'5' => Invoke77735X(code, p, args), 
			'7' => Invoke77737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7775XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77752X(code, p, args), 
			'6' => Invoke77756X(code, p, args), 
			'3' => Invoke77753X(code, p, args), 
			'5' => Invoke77755X(code, p, args), 
			'7' => Invoke77757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke7777XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke77772X(code, p, args), 
			'6' => Invoke77776X(code, p, args), 
			'3' => Invoke77773X(code, p, args), 
			'5' => Invoke77775X(code, p, args), 
			'7' => Invoke77777X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke72777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke76777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke73777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke75777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke77777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}
}
