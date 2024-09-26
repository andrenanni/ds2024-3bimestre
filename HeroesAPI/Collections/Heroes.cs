using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HeroesAPI.Collections;

[Table("heroes")]
[BsonIgnoreExtraElements]
public class Heroes
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("nome")]
    [JsonPropertyName("Nome")]
    public string Nome { get; set; }

    [BsonElement("time")]
    [JsonPropertyName("Time")]
    public string Time { get; set; }

    [BsonElement("idade")]
    [JsonPropertyName("Idade")]
    public int Idade { get; set; }

    [BsonElement("genero")]
    [JsonPropertyName("Genero")]
    public string Genero { get; set; }

    [BsonElement("habilidades")]
    [JsonPropertyName("Habilidades")]
    public List<string> Habilidades { get; set; }

    [BsonElement("usaCapa")]
    [JsonPropertyName("Usa Capa")]
    public bool UsaCapa { get; set; }

    [BsonElement("universo")]
    [JsonPropertyName("Universo")]
    public string Universo { get; set; }
}