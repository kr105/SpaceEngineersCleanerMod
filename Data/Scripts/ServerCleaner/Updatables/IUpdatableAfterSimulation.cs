﻿namespace ServerCleaner.Updatables
{
	public interface IUpdatableAfterSimulation
	{
		void UpdateAfterSimulation();

		void Close();
	}
}
