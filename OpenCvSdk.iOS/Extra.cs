namespace OpenCvSdk
{
	public partial class CvType
	{
		// type depth constants
		public const int
			Cv8u = 0,
			Cv8s = 1,
			Cv16u = 2,
			Cv16s = 3,
			Cv32s = 4,
			Cv32f = 5,
			Cv64f = 6,
			Cv16f = 7;

		public static int Cv8uc(int ch) => MakeType(Cv8u, ch);
		public static int Cv8sc(int ch) => MakeType(Cv8s, ch);
		public static int Cv16uc(int ch) => MakeType(Cv16u, ch);
		public static int Cv16sc(int ch) => MakeType(Cv16s, ch);
		public static int Cv32sc(int ch) => MakeType(Cv32s, ch);
		public static int Cv32fc(int ch) => MakeType(Cv32f, ch);
		public static int Cv64fc(int ch) => MakeType(Cv64f, ch);
		public static int Cv16fc(int ch) => MakeType(Cv16f, ch);

		// predefined type constants
		public static int
			Cv8uc1 = Cv8uc(1), Cv8uc2 = Cv8uc(2), Cv8uc3 = Cv8uc(3), Cv8uc4 = Cv8uc(4),
			Cv8sc1 = Cv8sc(1), Cv8sc2 = Cv8sc(2), Cv8sc3 = Cv8sc(3), Cv8sc4 = Cv8sc(4),
			Cv16uc1 = Cv16uc(1), Cv16uc2 = Cv16uc(2), Cv16uc3 = Cv16uc(3), Cv16uc4 = Cv16uc(4),
			Cv16sc1 = Cv16sc(1), Cv16sc2 = Cv16sc(2), Cv16sc3 = Cv16sc(3), Cv16sc4 = Cv16sc(4),
			Cv32sc1 = Cv32sc(1), Cv32sc2 = Cv32sc(2), Cv32sc3 = Cv32sc(3), Cv32sc4 = Cv32sc(4),
			Cv32fc1 = Cv32fc(1), Cv32fc2 = Cv32fc(2), Cv32fc3 = Cv32fc(3), Cv32fc4 = Cv32fc(4),
			Cv64fc1 = Cv64fc(1), Cv64fc2 = Cv64fc(2), Cv64fc3 = Cv64fc(3), Cv64fc4 = Cv64fc(4),
			Cv16fc1 = Cv16fc(1), Cv16fc2 = Cv16fc(2), Cv16fc3 = Cv16fc(3), Cv16fc4 = Cv16fc(4);
	}
}
