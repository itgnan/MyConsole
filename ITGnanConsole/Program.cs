// See https://aka.ms/new-console-template for more information
using ITGnanConsole.IQ;
using ITGnanConsole.IQ.Models;
using System.Text.Json;

Console.WriteLine("Hello, World!");

string inputJson = "{\r\n  \"name\": \"app-messages\",\r\n  \"published\": \"20250425T14:16:56\",\r\n  \"message\": [\r\n    {\r\n      \"name\": \"message\",\r\n      \"messageId\": {\r\n        \"type\": \"string\",\r\n        \"text\": \"restrictedCreditCardToastMessage\"\r\n      },\r\n      \"title\": {\r\n        \"type\": \"string\"\r\n      },\r\n      \"subTitle\": {\r\n        \"type\": \"string\"\r\n      },\r\n      \"body\": {\r\n        \"type\": \"string\",\r\n        \"text\": \"Sorry, we no longer accept Discover and JCB cards . Please enter a new card.\"\r\n      }\r\n    },\r\n    {\r\n      \"name\": \"message\",\r\n      \"messageId\": {\r\n        \"type\": \"string\",\r\n        \"text\": \"restrictedCreditCardInlineMessage\"\r\n      },\r\n      \"title\": {\r\n        \"type\": \"string\"\r\n      },\r\n      \"subTitle\": {\r\n        \"type\": \"string\"\r\n      },\r\n      \"body\": {\r\n        \"type\": \"string\",\r\n        \"text\": \"Discover and JCB cards are no longer accepted for payment\"\r\n      }\r\n    }\r\n  ]\r\n}";
var appMessages = JsonSerializer.Deserialize<AppMessages>(inputJson);


ZTesting zTesting = new ZTesting();
var messages = zTesting.GetMessages(appMessages?.Message);