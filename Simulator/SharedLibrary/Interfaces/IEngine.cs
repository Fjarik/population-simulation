﻿using System;
using System.Collections.Generic;
using System.Text;
using SharedLibrary.Interfaces.Entity;
using SharedLibrary.Interfaces.Statistics;

namespace SharedLibrary.Interfaces
{
	public interface IEngine<TEntity> where TEntity : class, IEntity
	{
		List<TEntity> Entities { get; set; }

		bool IsConfigurated { get; }
		int Cycle { get; set; }

		void Configurate(List<TEntity> entities);
		void Reset();
		ICycleStatistics NextCycle();
		IAgingStatistics GetOlder();
		int MakeBabies();
		void MakeBaby(TEntity parent);
		void MakeBaby(TEntity father, TEntity mother);
		int SetPartners();
		void Kill(TEntity entity);
		int SetRandomPartner(TEntity original);
	}
}