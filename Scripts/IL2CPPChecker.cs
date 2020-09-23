namespace Kogane
{
	public static class IL2CPPChecker
	{
		public static bool IsIL2CPP
		{
			get
			{
#if ENABLE_IL2CPP
				return true;
#else
				return false;
#endif
			}
		}
	}
}