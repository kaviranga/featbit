using System.Text.Json.Nodes;
using Domain.Shared;

namespace Streaming.Protocol;

public record RpPayload(string EventType, List<RpPayloadItem> Items);

public record RpPayloadItem(
    Guid EnvId,
    SecretWithValue[] Secrets,
    IEnumerable<JsonObject> FeatureFlags,
    IEnumerable<JsonObject> Segments
);