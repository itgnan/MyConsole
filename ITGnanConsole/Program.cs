// See https://aka.ms/new-console-template for more information
using ITGnanConsole.IQ;
using ITGnanConsole.IQ.Models;
using System.Text.Json;

Console.WriteLine("Hello, World!");

string inputJson = "{   \"name\": \"app-messages\",   \"published\": \"20250425T14:16:56\",   \"message\": [     {       \"name\": \"message\",       \"messageId\": {         \"type\": \"string\",         \"text\": \"restrictedCreditCardToastMessage\"       },       \"title\": {         \"type\": \"string\"       },       \"subTitle\": {         \"type\": \"string\"       },       \"body\": {         \"type\": \"string\",         \"text\": \"Sorry, we no longer accept Discover and JCB cards . Please enter a new card.\"       }     },     {       \"name\": \"message\",       \"messageId\": {         \"type\": \"string\",         \"text\": \"restrictedCreditCardInlineMessage\"       },       \"title\": {         \"type\": \"string\"       },       \"subTitle\": {         \"type\": \"string\"       },       \"body\": {         \"type\": \"string\",         \"text\": \"Discover and JCB cards are no longer accepted for payment\"       }     }   ] }";
var appMessages = JsonSerializer.Deserialize<AppMessages>(inputJson);


ZTesting zTesting = new ZTesting();
var messages = zTesting.GetMessages(appMessages?.Message);