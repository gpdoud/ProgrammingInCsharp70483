﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_In_Csharp_70_483 {
	class Program {

		void Run() {
			/* Threads */
			//Chapter1.L0101_Creating_A_Thread.Start();
			//Chapter1.L0102_Using_A_Background_Thread.Start();
			//Chapter1.L0103_Parameterized_ThreadStart.Start();
			//Chapter1.L0104_Stopping_A_Thread.Start();
			//Chapter1.L0105_Using_ThreadStaticAttribute.Start();
			//Chapter1.L0106_Using_ThreadLocal.Start();
			//Chapter1.L0107_Queuing_Work_To_Thread_Pool.Start();
			/* Tasks */
			//Chapter1.L0108_Starting_A_Task.Start();
			//Chapter1.L0109_Using_A_Task_That_Returns_A_Value.Start();
			//Chapter1.L0110_Continuation_After_Task.Start();
			Chapter1.L0111_Schedule_Different_Continuation_Tasks.Start();
		}
		static void Main(string[] args) {
			(new Program()).Run();
		}
	}
}
