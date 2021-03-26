// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Runtime.Serialization;

#nullable restore
namespace Nest
{
	public enum AppliesTo
	{
		[EnumMember(Value = "actual")]
		Actual,
		[EnumMember(Value = "typical")]
		Typical,
		[EnumMember(Value = "diff_from_typical")]
		DiffFromTypical,
		[EnumMember(Value = "time")]
		Time
	}

	public enum ChunkingMode
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "manual")]
		Manual,
		[EnumMember(Value = "off")]
		Off
	}

	public enum ConditionOperator
	{
		[EnumMember(Value = "gt")]
		Gt,
		[EnumMember(Value = "gte")]
		Gte,
		[EnumMember(Value = "lt")]
		Lt,
		[EnumMember(Value = "lte")]
		Lte
	}

	public enum DatafeedState
	{
		[EnumMember(Value = "started")]
		Started,
		[EnumMember(Value = "stopped")]
		Stopped,
		[EnumMember(Value = "starting")]
		Starting,
		[EnumMember(Value = "stopping")]
		Stopping
	}

	public enum ExcludeFrequent
	{
		[EnumMember(Value = "all")]
		All,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "by")]
		By,
		[EnumMember(Value = "over")]
		Over
	}

	public enum JobState
	{
		[EnumMember(Value = "closing")]
		Closing,
		[EnumMember(Value = "closed")]
		Closed,
		[EnumMember(Value = "opened")]
		Opened,
		[EnumMember(Value = "failed")]
		Failed,
		[EnumMember(Value = "opening")]
		Opening
	}

	public enum MemoryStatus
	{
		[EnumMember(Value = "ok")]
		Ok,
		[EnumMember(Value = "soft_limit")]
		SoftLimit,
		[EnumMember(Value = "hard_limit")]
		HardLimit
	}

	public enum RuleAction
	{
		[EnumMember(Value = "skip_result")]
		SkipResult,
		[EnumMember(Value = "skip_model_update")]
		SkipModelUpdate
	}

	public enum RuleFilterType
	{
		[EnumMember(Value = "include")]
		Include,
		[EnumMember(Value = "exclude")]
		Exclude
	}
}