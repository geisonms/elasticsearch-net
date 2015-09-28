﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.MockData;
using static Nest.Infer;

namespace Tests.Aggregations
{
	public class Index_TranslogSettings
	{
		/**
		 */

		public class Usage : UsageTestBase<IIndexSettings, IndexSettingsDescriptor, IndexSettings>
		{
			protected override object ExpectJson => new Dictionary<string, object>
			{
				{"index.search.slowlog.threshold.query.warn", "10s"},
				{"index.search.slowlog.threshold.query.info", "5s"},
				{"index.search.slowlog.threshold.query.debug", "2s"},
				{"index.search.slowlog.threshold.query.trace", "500ms"},
				{"index.search.slowlog.threshold.fetch.warn", "1s"},
				{"index.search.slowlog.threshold.fetch.info", "800ms"},
				{"index.search.slowlog.threshold.fetch.debug", "500ms"},
				{"index.search.slowlog.threshold.fetch.trace", "200ms"},
				{"index.search.slowlog.level", "info"},
				{"index.indexing.slowlog.threshold.index.warn", "10s"},
				{"index.indexing.slowlog.threshold.index.info", "5s"},
				{"index.indexing.slowlog.threshold.index.debug", "2s"},
				{"index.indexing.slowlog.threshold.index.trace", "500ms"},
				{"index.indexing.slowlog.level", "debug"},
				{"index.indexing.slowlog.source", 100},
			};
			/**
			 * 
			 */
			protected override Func<IndexSettingsDescriptor, IIndexSettings> Fluent => s => s
				.SlowLog(sl => sl
					.Indexing(i => i
						.ThresholdWarn("10s")
						.ThresholdInfo("5s")
						.ThresholdDebug(TimeSpan.FromSeconds(2))
						.ThresholdTrace(TimeSpan.FromMilliseconds(500))
						.LogLevel(SlowLogLevel.Debug)
						.Source(100)
					)
					.Search(search => search
						.Query(q => q
							.ThresholdWarn("10s")
							.ThresholdInfo("5s")
							.ThresholdDebug(TimeSpan.FromSeconds(2))
							.ThresholdTrace(TimeSpan.FromMilliseconds(500))
						)
						.Fetch(f => f
							.ThresholdWarn("1s")
							.ThresholdInfo("800ms")
							.ThresholdDebug(TimeSpan.FromMilliseconds(500))
							.ThresholdTrace(TimeSpan.FromMilliseconds(200))
						)
						.LogLevel(SlowLogLevel.Info)
					)
				);

			/**
			 */
			protected override IndexSettings Initializer =>
				new IndexSettings
				{
					SlowLog = new SlowLog
					{
						Indexing = new SlowLogIndexing
						{
							LogLevel = SlowLogLevel.Debug,
							Source = 100,
							ThresholdInfo = TimeSpan.FromSeconds(5),
							ThresholdDebug = "2s",
							ThresholdTrace = "500ms",
							ThresholdWarn = TimeSpan.FromSeconds(10)
						},
						Search = new SlowLogSearch
						{
							LogLevel = SlowLogLevel.Info,
							Fetch = new SlowLogSearchFetch
							{

								ThresholdInfo = TimeSpan.FromMilliseconds(800),
								ThresholdDebug = "500ms",
								ThresholdTrace = "200ms",
								ThresholdWarn = TimeSpan.FromSeconds(1)
							},
							Query = new SlowLogSearchQuery
							{
								ThresholdInfo = TimeSpan.FromSeconds(5),
								ThresholdDebug = "2s",
								ThresholdTrace = "500ms",
								ThresholdWarn = TimeSpan.FromSeconds(10)
							}

						}
					},
				};
		}
	}
}
