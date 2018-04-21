// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BotState.
    /// </summary>
    public static partial class BotStateExtensions
    {
            /// <summary>
            /// GetUserData
            /// </summary>
            /// <remarks>
            /// Get a bots data for the user across all conversations
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            [System.Obsolete()]
            public static BotData GetUserData(this IBotState operations, string channelId, string userId)
            {
                return operations.GetUserDataAsync(channelId, userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// GetUserData
            /// </summary>
            /// <remarks>
            /// Get a bots data for the user across all conversations
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete()]
            public static async Task<BotData> GetUserDataAsync(this IBotState operations, string channelId, string userId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetUserDataWithHttpMessagesAsync(channelId, userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// SetUserData
            /// </summary>
            /// <remarks>
            /// Update the bot's data for a user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            /// <param name='botData'>
            /// the new botdata
            /// </param>
            [System.Obsolete()]
            public static BotData SetUserData(this IBotState operations, string channelId, string userId, BotData botData)
            {
                return operations.SetUserDataAsync(channelId, userId, botData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// SetUserData
            /// </summary>
            /// <remarks>
            /// Update the bot's data for a user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            /// <param name='botData'>
            /// the new botdata
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete()]
            public static async Task<BotData> SetUserDataAsync(this IBotState operations, string channelId, string userId, BotData botData, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetUserDataWithHttpMessagesAsync(channelId, userId, botData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// DeleteStateForUser
            /// </summary>
            /// <remarks>
            /// Delete all data for a user in a channel (UserData and
            /// PrivateConversationData)
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            [System.Obsolete()]
            public static IList<string> DeleteStateForUser(this IBotState operations, string channelId, string userId)
            {
                return operations.DeleteStateForUserAsync(channelId, userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// DeleteStateForUser
            /// </summary>
            /// <remarks>
            /// Delete all data for a user in a channel (UserData and
            /// PrivateConversationData)
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete()]
            public static async Task<IList<string>> DeleteStateForUserAsync(this IBotState operations, string channelId, string userId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteStateForUserWithHttpMessagesAsync(channelId, userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// GetConversationData
            /// </summary>
            /// <remarks>
            /// get the bots data for all users in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// the channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            [System.Obsolete()]
            public static BotData GetConversationData(this IBotState operations, string channelId, string conversationId)
            {
                return operations.GetConversationDataAsync(channelId, conversationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// GetConversationData
            /// </summary>
            /// <remarks>
            /// get the bots data for all users in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// the channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete()]
            public static async Task<BotData> GetConversationDataAsync(this IBotState operations, string channelId, string conversationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetConversationDataWithHttpMessagesAsync(channelId, conversationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// SetConversationData
            /// </summary>
            /// <remarks>
            /// Update the bot's data for all users in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            /// <param name='botData'>
            /// the new botdata
            /// </param>
            [System.Obsolete()]
            public static BotData SetConversationData(this IBotState operations, string channelId, string conversationId, BotData botData)
            {
                return operations.SetConversationDataAsync(channelId, conversationId, botData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// SetConversationData
            /// </summary>
            /// <remarks>
            /// Update the bot's data for all users in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            /// <param name='botData'>
            /// the new botdata
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete()]
            public static async Task<BotData> SetConversationDataAsync(this IBotState operations, string channelId, string conversationId, BotData botData, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetConversationDataWithHttpMessagesAsync(channelId, conversationId, botData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// GetPrivateConversationData
            /// </summary>
            /// <remarks>
            /// get bot's data for a single user in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            [System.Obsolete()]
            public static BotData GetPrivateConversationData(this IBotState operations, string channelId, string conversationId, string userId)
            {
                return operations.GetPrivateConversationDataAsync(channelId, conversationId, userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// GetPrivateConversationData
            /// </summary>
            /// <remarks>
            /// get bot's data for a single user in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete()]
            public static async Task<BotData> GetPrivateConversationDataAsync(this IBotState operations, string channelId, string conversationId, string userId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPrivateConversationDataWithHttpMessagesAsync(channelId, conversationId, userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// SetPrivateConversationData
            /// </summary>
            /// <remarks>
            /// Update the bot's data for a single user in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            /// <param name='botData'>
            /// the new botdata
            /// </param>
            [System.Obsolete()]
            public static BotData SetPrivateConversationData(this IBotState operations, string channelId, string conversationId, string userId, BotData botData)
            {
                return operations.SetPrivateConversationDataAsync(channelId, conversationId, userId, botData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// SetPrivateConversationData
            /// </summary>
            /// <remarks>
            /// Update the bot's data for a single user in a conversation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='channelId'>
            /// channelId
            /// </param>
            /// <param name='conversationId'>
            /// The id for the conversation on the channel
            /// </param>
            /// <param name='userId'>
            /// id for the user on the channel
            /// </param>
            /// <param name='botData'>
            /// the new botdata
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete()]
            public static async Task<BotData> SetPrivateConversationDataAsync(this IBotState operations, string channelId, string conversationId, string userId, BotData botData, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetPrivateConversationDataWithHttpMessagesAsync(channelId, conversationId, userId, botData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}