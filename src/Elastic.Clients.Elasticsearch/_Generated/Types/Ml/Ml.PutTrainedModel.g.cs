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
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml.PutTrainedModel
{
	public partial class AggregateOutput
	{
		[JsonPropertyName("exponent")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.Weights? Exponent { get; set; }

		[JsonPropertyName("logistic_regression")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.Weights? LogisticRegression { get; set; }

		[JsonPropertyName("weighted_mode")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.Weights? WeightedMode { get; set; }

		[JsonPropertyName("weighted_sum")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.Weights? WeightedSum { get; set; }
	}

	public partial class Definition
	{
		[JsonPropertyName("preprocessors")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.Preprocessor>? Preprocessors { get; set; }

		[JsonPropertyName("trained_model")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.TrainedModel TrainedModel { get; set; }
	}

	public partial class Ensemble
	{
		[JsonPropertyName("aggregate_output")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.AggregateOutput? AggregateOutput { get; set; }

		[JsonPropertyName("classification_labels")]
		public IEnumerable<string>? ClassificationLabels { get; set; }

		[JsonPropertyName("feature_names")]
		public IEnumerable<string>? FeatureNames { get; set; }

		[JsonPropertyName("target_type")]
		public string? TargetType { get; set; }

		[JsonPropertyName("trained_models")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.TrainedModel> TrainedModels { get; set; }
	}

	public partial class FrequencyEncodingPreprocessor
	{
		[JsonPropertyName("feature_name")]
		public string FeatureName { get; set; }

		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonPropertyName("frequency_map")]
		public Dictionary<string, double> FrequencyMap { get; set; }
	}

	public partial class Input
	{
		[JsonPropertyName("field_names")]
		public Elastic.Clients.Elasticsearch.Names FieldNames { get; set; }
	}

	public partial class OneHotEncodingPreprocessor
	{
		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonPropertyName("hot_map")]
		public Dictionary<string, string> HotMap { get; set; }
	}

	public partial class Preprocessor
	{
		[JsonPropertyName("frequency_encoding")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.FrequencyEncodingPreprocessor? FrequencyEncoding { get; set; }

		[JsonPropertyName("one_hot_encoding")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.OneHotEncodingPreprocessor? OneHotEncoding { get; set; }

		[JsonPropertyName("target_mean_encoding")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.TargetMeanEncodingPreprocessor? TargetMeanEncoding { get; set; }
	}

	public partial class TargetMeanEncodingPreprocessor
	{
		[JsonPropertyName("default_value")]
		public double DefaultValue { get; set; }

		[JsonPropertyName("feature_name")]
		public string FeatureName { get; set; }

		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonPropertyName("target_map")]
		public Dictionary<string, double> TargetMap { get; set; }
	}

	public partial class TrainedModel
	{
		[JsonPropertyName("ensemble")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.Ensemble? Ensemble { get; set; }

		[JsonPropertyName("tree")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.TrainedModelTree? Tree { get; set; }

		[JsonPropertyName("tree_node")]
		public Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.TrainedModelTreeNode? TreeNode { get; set; }
	}

	public partial class TrainedModelTree
	{
		[JsonPropertyName("classification_labels")]
		public IEnumerable<string>? ClassificationLabels { get; set; }

		[JsonPropertyName("feature_names")]
		public IEnumerable<string> FeatureNames { get; set; }

		[JsonPropertyName("target_type")]
		public string? TargetType { get; set; }

		[JsonPropertyName("tree_structure")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.PutTrainedModel.TrainedModelTreeNode> TreeStructure { get; set; }
	}

	public partial class TrainedModelTreeNode
	{
		[JsonPropertyName("decision_type")]
		public string? DecisionType { get; set; }

		[JsonPropertyName("default_left")]
		public bool? DefaultLeft { get; set; }

		[JsonPropertyName("leaf_value")]
		public double? LeafValue { get; set; }

		[JsonPropertyName("left_child")]
		public int? LeftChild { get; set; }

		[JsonPropertyName("node_index")]
		public int NodeIndex { get; set; }

		[JsonPropertyName("right_child")]
		public int? RightChild { get; set; }

		[JsonPropertyName("split_feature")]
		public int? SplitFeature { get; set; }

		[JsonPropertyName("split_gain")]
		public int? SplitGain { get; set; }

		[JsonPropertyName("threshold")]
		public double? Threshold { get; set; }
	}

	public partial class Weights
	{
	}
}