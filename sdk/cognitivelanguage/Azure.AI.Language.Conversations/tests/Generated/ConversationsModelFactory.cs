// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ConversationsModelFactory
    {
        /// <summary> Initializes a new instance of AnalyzeConversationJobState. </summary>
        /// <param name="displayName"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="expirationDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="status"></param>
        /// <param name="errors"></param>
        /// <param name="nextLink"></param>
        /// <param name="tasks"></param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <returns> A new <see cref="Conversations.AnalyzeConversationJobState"/> instance for mocking. </returns>
        public static AnalyzeConversationJobState AnalyzeConversationJobState(string displayName = null, DateTimeOffset createdDateTime = default, DateTimeOffset? expirationDateTime = null, string jobId = null, DateTimeOffset lastUpdatedDateTime = default, JobState status = default, IEnumerable<Error> errors = null, string nextLink = null, ConversationTasksStateTasks tasks = null, ConversationRequestStatistics statistics = null)
        {
            errors ??= new List<Error>();

            return new AnalyzeConversationJobState(displayName, createdDateTime, expirationDateTime, jobId, lastUpdatedDateTime, status, errors?.ToList(), nextLink, tasks, statistics);
        }

        /// <summary> Initializes a new instance of JobStateAutoGenerated. </summary>
        /// <param name="displayName"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="expirationDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="status"></param>
        /// <param name="errors"></param>
        /// <param name="nextLink"></param>
        /// <returns> A new <see cref="Conversations.JobStateAutoGenerated"/> instance for mocking. </returns>
        public static JobStateAutoGenerated JobStateAutoGenerated(string displayName = null, DateTimeOffset createdDateTime = default, DateTimeOffset? expirationDateTime = null, string jobId = null, DateTimeOffset lastUpdatedDateTime = default, JobState status = default, IEnumerable<Error> errors = null, string nextLink = null)
        {
            errors ??= new List<Error>();

            return new JobStateAutoGenerated(displayName, createdDateTime, expirationDateTime, jobId, lastUpdatedDateTime, status, errors?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of ConversationTasksState. </summary>
        /// <param name="tasks"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="tasks"/> is null. </exception>
        /// <returns> A new <see cref="Conversations.ConversationTasksState"/> instance for mocking. </returns>
        public static ConversationTasksState ConversationTasksState(ConversationTasksStateTasks tasks = null)
        {
            if (tasks == null)
            {
                throw new ArgumentNullException(nameof(tasks));
            }

            return new ConversationTasksState(tasks);
        }

        /// <summary> Initializes a new instance of ConversationTasksStateTasks. </summary>
        /// <param name="completed"> Count of tasks completed successfully. </param>
        /// <param name="failed"> Count of tasks that failed. </param>
        /// <param name="inProgress"> Count of tasks in progress currently. </param>
        /// <param name="total"> Total count of tasks submitted as part of the job. </param>
        /// <param name="items"> List of results from tasks (if available). </param>
        /// <returns> A new <see cref="Conversations.ConversationTasksStateTasks"/> instance for mocking. </returns>
        public static ConversationTasksStateTasks ConversationTasksStateTasks(int completed = default, int failed = default, int inProgress = default, int total = default, IEnumerable<AnalyzeConversationJobResult> items = null)
        {
            items ??= new List<AnalyzeConversationJobResult>();

            return new ConversationTasksStateTasks(completed, failed, inProgress, total, items?.ToList());
        }

        /// <summary> Initializes a new instance of AnalyzeConversationJobStatistics. </summary>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <returns> A new <see cref="Conversations.AnalyzeConversationJobStatistics"/> instance for mocking. </returns>
        public static AnalyzeConversationJobStatistics AnalyzeConversationJobStatistics(ConversationRequestStatistics statistics = null)
        {
            return new AnalyzeConversationJobStatistics(statistics);
        }

        /// <summary> Initializes a new instance of ConversationalTaskResult. </summary>
        /// <param name="kind"> Enumeration of supported conversational task results. </param>
        /// <param name="result"> Represents a conversation analysis response. </param>
        /// <returns> A new <see cref="Conversations.ConversationalTaskResult"/> instance for mocking. </returns>
        public static ConversationalTaskResult ConversationalTaskResult(AnalyzeConversationTaskResultsKind kind = default, AnalyzeConversationResult result = null)
        {
            return new ConversationalTaskResult(kind, result);
        }

        /// <summary> Initializes a new instance of AnalyzeConversationResult. </summary>
        /// <param name="query"> The conversation utterance given by the caller. </param>
        /// <param name="detectedLanguage"> The system detected language for the query in BCP 47 language representation.. </param>
        /// <param name="prediction"> The prediction result of a conversation project. </param>
        /// <returns> A new <see cref="Conversations.AnalyzeConversationResult"/> instance for mocking. </returns>
        public static AnalyzeConversationResult AnalyzeConversationResult(string query = null, string detectedLanguage = null, BasePrediction prediction = null)
        {
            return new AnalyzeConversationResult(query, detectedLanguage, prediction);
        }

        /// <summary> Initializes a new instance of BasePrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <returns> A new <see cref="Conversations.BasePrediction"/> instance for mocking. </returns>
        public static BasePrediction BasePrediction(ProjectKind projectKind = default, string topIntent = null)
        {
            return new BasePrediction(projectKind, topIntent);
        }

        /// <summary> Initializes a new instance of NoneLinkedTargetIntentResult. </summary>
        /// <param name="targetProjectKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a Conversation project. </param>
        /// <returns> A new <see cref="Conversations.NoneLinkedTargetIntentResult"/> instance for mocking. </returns>
        public static NoneLinkedTargetIntentResult NoneLinkedTargetIntentResult(TargetProjectKind targetProjectKind = default, string apiVersion = null, double confidence = default, ConversationResult result = null)
        {
            return new NoneLinkedTargetIntentResult(targetProjectKind, apiVersion, confidence, result);
        }

        /// <summary> Initializes a new instance of ConversationResult. </summary>
        /// <param name="query"> The same query given in request. </param>
        /// <param name="detectedLanguage"> The detected language from the query in BCP 47 language representation.. </param>
        /// <param name="prediction"> The predicted result for the query. </param>
        /// <returns> A new <see cref="Conversations.ConversationResult"/> instance for mocking. </returns>
        public static ConversationResult ConversationResult(string query = null, string detectedLanguage = null, ConversationPrediction prediction = null)
        {
            return new ConversationResult(query, detectedLanguage, prediction);
        }

        /// <summary> Initializes a new instance of ConversationPrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <param name="intents"> The intent classification results. </param>
        /// <param name="entities"> The entity extraction results. </param>
        /// <returns> A new <see cref="Conversations.ConversationPrediction"/> instance for mocking. </returns>
        public static ConversationPrediction ConversationPrediction(ProjectKind projectKind = default, string topIntent = null, IEnumerable<ConversationIntent> intents = null, IEnumerable<ConversationEntity> entities = null)
        {
            intents ??= new List<ConversationIntent>();
            entities ??= new List<ConversationEntity>();

            return new ConversationPrediction(projectKind, topIntent, intents?.ToList(), entities?.ToList());
        }

        /// <summary> Initializes a new instance of ConversationIntent. </summary>
        /// <param name="category"> A predicted class. </param>
        /// <param name="confidence"> The confidence score of the class from 0.0 to 1.0. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="category"/> is null. </exception>
        /// <returns> A new <see cref="Conversations.ConversationIntent"/> instance for mocking. </returns>
        public static ConversationIntent ConversationIntent(string category = null, float confidence = default)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            return new ConversationIntent(category, confidence);
        }

        /// <summary> Initializes a new instance of ConversationEntity. </summary>
        /// <param name="category"> The entity category. </param>
        /// <param name="text"> The predicted entity text. </param>
        /// <param name="offset"> The starting index of this entity in the query. </param>
        /// <param name="length"> The length of the text. </param>
        /// <param name="confidence"> The entity confidence score. </param>
        /// <param name="resolutions"> The collection of entity resolution objects. </param>
        /// <param name="extraInformation"> The collection of entity extra information objects. </param>
        /// <returns> A new <see cref="Conversations.ConversationEntity"/> instance for mocking. </returns>
        public static ConversationEntity ConversationEntity(string category = null, string text = null, int offset = default, int length = default, float confidence = default, IEnumerable<BaseResolution> resolutions = null, IEnumerable<BaseExtraInformation> extraInformation = null)
        {
            resolutions ??= new List<BaseResolution>();
            extraInformation ??= new List<BaseExtraInformation>();

            return new ConversationEntity(category, text, offset, length, confidence, resolutions?.ToList(), extraInformation?.ToList());
        }

        /// <summary> Initializes a new instance of TargetIntentResult. </summary>
        /// <param name="targetProjectKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <returns> A new <see cref="Conversations.TargetIntentResult"/> instance for mocking. </returns>
        public static TargetIntentResult TargetIntentResult(TargetProjectKind targetProjectKind = default, string apiVersion = null, double confidence = default)
        {
            return new TargetIntentResult(targetProjectKind, apiVersion, confidence);
        }

        /// <summary> Initializes a new instance of OrchestrationPrediction. </summary>
        /// <param name="projectKind"> The type of the project. </param>
        /// <param name="topIntent"> The intent with the highest score. </param>
        /// <param name="intents"> A dictionary that contains all intents. A key is an intent name and a value is its confidence score and target type. The top intent&apos;s value also contains the actual response from the target project. </param>
        /// <returns> A new <see cref="Conversations.OrchestrationPrediction"/> instance for mocking. </returns>
        public static OrchestrationPrediction OrchestrationPrediction(ProjectKind projectKind = default, string topIntent = null, IReadOnlyDictionary<string, TargetIntentResult> intents = null)
        {
            intents ??= new Dictionary<string, TargetIntentResult>();

            return new OrchestrationPrediction(projectKind, topIntent, intents);
        }

        /// <summary> Initializes a new instance of ConversationTargetIntentResult. </summary>
        /// <param name="targetProjectKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a Conversation project. </param>
        /// <returns> A new <see cref="Conversations.ConversationTargetIntentResult"/> instance for mocking. </returns>
        public static ConversationTargetIntentResult ConversationTargetIntentResult(TargetProjectKind targetProjectKind = default, string apiVersion = null, double confidence = default, ConversationResult result = null)
        {
            return new ConversationTargetIntentResult(targetProjectKind, apiVersion, confidence, result);
        }

        /// <summary> Initializes a new instance of EntitySubtype. </summary>
        /// <param name="extraInformationKind"> The extra information object kind. </param>
        /// <param name="value"> The Subtype of an extracted entity type. </param>
        /// <returns> A new <see cref="Conversations.EntitySubtype"/> instance for mocking. </returns>
        public static EntitySubtype EntitySubtype(ExtraInformationKind extraInformationKind = default, string value = null)
        {
            return new EntitySubtype(extraInformationKind, value);
        }

        /// <summary> Initializes a new instance of ListKey. </summary>
        /// <param name="extraInformationKind"> The extra information object kind. </param>
        /// <param name="key"> The canonical form of the extracted entity. </param>
        /// <returns> A new <see cref="Conversations.ListKey"/> instance for mocking. </returns>
        public static ListKey ListKey(ExtraInformationKind extraInformationKind = default, string key = null)
        {
            return new ListKey(extraInformationKind, key);
        }

        /// <summary> Initializes a new instance of QuantityResolution. </summary>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.QuantityResolution"/> instance for mocking. </returns>
        public static QuantityResolution QuantityResolution(double value = default)
        {
            return new QuantityResolution(value);
        }

        /// <summary> Initializes a new instance of AgeResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The Age Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.AgeResolution"/> instance for mocking. </returns>
        public static AgeResolution AgeResolution(ResolutionKind resolutionKind = default, AgeUnit unit = default, double value = default)
        {
            return new AgeResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of VolumeResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The Volume Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.VolumeResolution"/> instance for mocking. </returns>
        public static VolumeResolution VolumeResolution(ResolutionKind resolutionKind = default, VolumeUnit unit = default, double value = default)
        {
            return new VolumeResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of SpeedResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The speed Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.SpeedResolution"/> instance for mocking. </returns>
        public static SpeedResolution SpeedResolution(ResolutionKind resolutionKind = default, SpeedUnit unit = default, double value = default)
        {
            return new SpeedResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of AreaResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The area Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.AreaResolution"/> instance for mocking. </returns>
        public static AreaResolution AreaResolution(ResolutionKind resolutionKind = default, AreaUnit unit = default, double value = default)
        {
            return new AreaResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of LengthResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The length Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.LengthResolution"/> instance for mocking. </returns>
        public static LengthResolution LengthResolution(ResolutionKind resolutionKind = default, LengthUnit unit = default, double value = default)
        {
            return new LengthResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of InformationResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The information (data) Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.InformationResolution"/> instance for mocking. </returns>
        public static InformationResolution InformationResolution(ResolutionKind resolutionKind = default, InformationUnit unit = default, double value = default)
        {
            return new InformationResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of TemperatureResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The temperature Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.TemperatureResolution"/> instance for mocking. </returns>
        public static TemperatureResolution TemperatureResolution(ResolutionKind resolutionKind = default, TemperatureUnit unit = default, double value = default)
        {
            return new TemperatureResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of WeightResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The weight Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.WeightResolution"/> instance for mocking. </returns>
        public static WeightResolution WeightResolution(ResolutionKind resolutionKind = default, WeightUnit unit = default, double value = default)
        {
            return new WeightResolution(resolutionKind, unit, value);
        }

        /// <summary> Initializes a new instance of CurrencyResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="isO4217"> The alphabetic code based on another ISO standard, ISO 3166, which lists the codes for country names. The first two letters of the ISO 4217 three-letter code are the same as the code for the country name, and, where possible, the third letter corresponds to the first letter of the currency name. </param>
        /// <param name="unit"> The unit of the amount captured in the extracted entity. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.CurrencyResolution"/> instance for mocking. </returns>
        public static CurrencyResolution CurrencyResolution(ResolutionKind resolutionKind = default, string isO4217 = null, string unit = null, double value = default)
        {
            return new CurrencyResolution(resolutionKind, isO4217, unit, value);
        }

        /// <summary> Initializes a new instance of BooleanResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="value"></param>
        /// <returns> A new <see cref="Conversations.BooleanResolution"/> instance for mocking. </returns>
        public static BooleanResolution BooleanResolution(ResolutionKind resolutionKind = default, bool value = default)
        {
            return new BooleanResolution(resolutionKind, value);
        }

        /// <summary> Initializes a new instance of DateTimeResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="timex"> An extended ISO 8601 date/time representation as described in (https://github.com/Microsoft/Recognizers-Text/blob/master/Patterns/English/English-DateTime.yaml). </param>
        /// <param name="dateTimeSubKind"> The DateTime SubKind. </param>
        /// <param name="value"> The actual time that the extracted text denote. </param>
        /// <param name="modifier"> An optional modifier of a date/time instance. </param>
        /// <returns> A new <see cref="Conversations.DateTimeResolution"/> instance for mocking. </returns>
        public static DateTimeResolution DateTimeResolution(ResolutionKind resolutionKind = default, string timex = null, DateTimeSubKind dateTimeSubKind = default, string value = null, TemporalModifier? modifier = null)
        {
            return new DateTimeResolution(resolutionKind, timex, dateTimeSubKind, value, modifier);
        }

        /// <summary> Initializes a new instance of NumberResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="numberKind"> The type of the extracted number entity. </param>
        /// <param name="value"> A numeric representation of what the extracted text denotes. </param>
        /// <returns> A new <see cref="Conversations.NumberResolution"/> instance for mocking. </returns>
        public static NumberResolution NumberResolution(ResolutionKind resolutionKind = default, NumberKind numberKind = default, string value = null)
        {
            return new NumberResolution(resolutionKind, numberKind, value);
        }

        /// <summary> Initializes a new instance of OrdinalResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="offset"> The offset With respect to the reference (e.g., offset = -1 in &quot;show me the second to last&quot;. </param>
        /// <param name="relativeTo"> The reference point that the ordinal number denotes. </param>
        /// <param name="value"> A simple arithmetic expression that the ordinal denotes. </param>
        /// <returns> A new <see cref="Conversations.OrdinalResolution"/> instance for mocking. </returns>
        public static OrdinalResolution OrdinalResolution(ResolutionKind resolutionKind = default, string offset = null, RelativeTo relativeTo = default, string value = null)
        {
            return new OrdinalResolution(resolutionKind, offset, relativeTo, value);
        }

        /// <summary> Initializes a new instance of TemporalSpanResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="begin"> An extended ISO 8601 date/time representation as described in (https://github.com/Microsoft/Recognizers-Text/blob/master/Patterns/English/English-DateTime.yaml). </param>
        /// <param name="end"> An extended ISO 8601 date/time representation as described in (https://github.com/Microsoft/Recognizers-Text/blob/master/Patterns/English/English-DateTime.yaml). </param>
        /// <param name="duration"> An optional duration value formatted based on the ISO 8601 (https://en.wikipedia.org/wiki/ISO_8601#Durations). </param>
        /// <param name="modifier"> An optional modifier of a date/time instance. </param>
        /// <returns> A new <see cref="Conversations.TemporalSpanResolution"/> instance for mocking. </returns>
        public static TemporalSpanResolution TemporalSpanResolution(ResolutionKind resolutionKind = default, string begin = null, string end = null, string duration = null, TemporalModifier? modifier = null)
        {
            return new TemporalSpanResolution(resolutionKind, begin, end, duration, modifier);
        }

        /// <summary> Initializes a new instance of NumericRangeResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="rangeKind"> The kind of range that the resolution object represents. </param>
        /// <param name="minimum"> The beginning value of  the interval. </param>
        /// <param name="maximum"> The ending value of the interval. </param>
        /// <returns> A new <see cref="Conversations.NumericRangeResolution"/> instance for mocking. </returns>
        public static NumericRangeResolution NumericRangeResolution(ResolutionKind resolutionKind = default, RangeKind rangeKind = default, double minimum = default, double maximum = default)
        {
            return new NumericRangeResolution(resolutionKind, rangeKind, minimum, maximum);
        }

        /// <summary> Initializes a new instance of LuisTargetIntentResult. </summary>
        /// <param name="targetProjectKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a LUIS Generally Available application. </param>
        /// <returns> A new <see cref="Conversations.LuisTargetIntentResult"/> instance for mocking. </returns>
        public static LuisTargetIntentResult LuisTargetIntentResult(TargetProjectKind targetProjectKind = default, string apiVersion = null, double confidence = default, object result = null)
        {
            return new LuisTargetIntentResult(targetProjectKind, apiVersion, confidence, result);
        }

        /// <summary> Initializes a new instance of QuestionAnsweringTargetIntentResult. </summary>
        /// <param name="targetProjectKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The generated answer by a Question Answering KB. </param>
        /// <returns> A new <see cref="Conversations.QuestionAnsweringTargetIntentResult"/> instance for mocking. </returns>
        public static QuestionAnsweringTargetIntentResult QuestionAnsweringTargetIntentResult(TargetProjectKind targetProjectKind = default, string apiVersion = null, double confidence = default, AnswersResult result = null)
        {
            return new QuestionAnsweringTargetIntentResult(targetProjectKind, apiVersion, confidence, result);
        }

        /// <summary> Initializes a new instance of AnswersResult. </summary>
        /// <param name="answers"> Represents Answer Result list. </param>
        /// <returns> A new <see cref="Conversations.AnswersResult"/> instance for mocking. </returns>
        public static AnswersResult AnswersResult(IEnumerable<KnowledgeBaseAnswer> answers = null)
        {
            answers ??= new List<KnowledgeBaseAnswer>();

            return new AnswersResult(answers?.ToList());
        }

        /// <summary> Initializes a new instance of KnowledgeBaseAnswer. </summary>
        /// <param name="questions"> List of questions associated with the answer. </param>
        /// <param name="answer"> Answer text. </param>
        /// <param name="confidence"> Answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="qnaId"> ID of the QnA result. </param>
        /// <param name="source"> Source of QnA result. </param>
        /// <param name="metadata"> Metadata associated with the answer, useful to categorize or filter question answers. </param>
        /// <param name="dialog"> Dialog associated with Answer. </param>
        /// <param name="shortAnswer"> Answer span object of QnA with respect to user&apos;s question. </param>
        /// <returns> A new <see cref="Conversations.KnowledgeBaseAnswer"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswer KnowledgeBaseAnswer(IEnumerable<string> questions = null, string answer = null, double? confidence = null, int? qnaId = null, string source = null, IReadOnlyDictionary<string, string> metadata = null, KnowledgeBaseAnswerDialog dialog = null, AnswerSpan shortAnswer = null)
        {
            questions ??= new List<string>();
            metadata ??= new Dictionary<string, string>();

            return new KnowledgeBaseAnswer(questions?.ToList(), answer, confidence, qnaId, source, metadata, dialog, shortAnswer);
        }

        /// <summary> Initializes a new instance of KnowledgeBaseAnswerDialog. </summary>
        /// <param name="isContextOnly"> To mark if a prompt is relevant only with a previous question or not. If true, do not include this QnA as search result for queries without context; otherwise, if false, ignores context and includes this QnA in search result. </param>
        /// <param name="prompts"> List of prompts associated with the answer. </param>
        /// <returns> A new <see cref="Conversations.KnowledgeBaseAnswerDialog"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswerDialog KnowledgeBaseAnswerDialog(bool? isContextOnly = null, IEnumerable<KnowledgeBaseAnswerPrompt> prompts = null)
        {
            prompts ??= new List<KnowledgeBaseAnswerPrompt>();

            return new KnowledgeBaseAnswerDialog(isContextOnly, prompts?.ToList());
        }

        /// <summary> Initializes a new instance of KnowledgeBaseAnswerPrompt. </summary>
        /// <param name="displayOrder"> Index of the prompt - used in ordering of the prompts. </param>
        /// <param name="qnaId"> QnA ID corresponding to the prompt. </param>
        /// <param name="displayText"> Text displayed to represent a follow up question prompt. </param>
        /// <returns> A new <see cref="Conversations.KnowledgeBaseAnswerPrompt"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswerPrompt KnowledgeBaseAnswerPrompt(int? displayOrder = null, int? qnaId = null, string displayText = null)
        {
            return new KnowledgeBaseAnswerPrompt(displayOrder, qnaId, displayText);
        }

        /// <summary> Initializes a new instance of AnswerSpan. </summary>
        /// <param name="text"> Predicted text of answer span. </param>
        /// <param name="confidence"> Predicted score of answer span, value ranges from 0 to 1. </param>
        /// <param name="offset"> The answer span offset from the start of answer. </param>
        /// <param name="length"> The length of the answer span. </param>
        /// <returns> A new <see cref="Conversations.AnswerSpan"/> instance for mocking. </returns>
        public static AnswerSpan AnswerSpan(string text = null, double? confidence = null, int? offset = null, int? length = null)
        {
            return new AnswerSpan(text, confidence, offset, length);
        }
    }
}
