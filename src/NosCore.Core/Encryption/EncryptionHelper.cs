﻿using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NosCore.Core.Encryption
{
	public static class EncryptionHelper
	{
		public static string Sha512(string inputString)
		{
			using (var hash = SHA512.Create())
			{
				return string.Concat(hash.ComputeHash(Encoding.Default.GetBytes(inputString))
					.Select(item => item.ToString("x2")));
			}
		}
	}
}