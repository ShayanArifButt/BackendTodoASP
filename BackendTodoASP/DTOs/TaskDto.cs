using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BackendTodoASP.DTOs
{
    public class TaskDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 200 characters.")]
        public required string Description { get; set; }

        public bool IsDone { get; set; }

        [JsonConverter(typeof(JsonDateConverter))]
        public DateTime? Deadline { get; set; }
    }

    // Custom DateTime converter to serialize only the date part
    public class JsonDateConverter : JsonConverter<DateTime?>
    {
        private readonly string _format = "yyyy-MM-dd";

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                if (DateTime.TryParse(reader.GetString(), out var date))
                {
                    return date;
                }
            }
            return null;
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString(_format));
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
