using System;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;




namespace Ntsh.Threading {

	public static class TaskExtensions {

		public static ConfiguredTaskAwaitable Configure(this Task task)
			=> task.ConfigureAwait(false);

		public static ConfiguredTaskAwaitable<T> Configure<T>(this Task<T> task)
			=> task.ConfigureAwait(false);

	}

}
