﻿using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using shitcordbot.commands;
using shitcordbot.Commands;
using shitcordbot.Points;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace shitcordbot
{
    class Bot
    {
        public DiscordClient Client { get; private set; }
        public InteractivityExtension interactivity { get; private set; }
        public CommandsNextExtension Commands { get; private set; }
        public async Task RunAsync()
        {
            var json = string.Empty;

            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);

            var configJson = JsonConvert.DeserializeObject<ConfigJson>(json);

            var config = new DiscordConfiguration
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = LogLevel.Debug,
                //UseInternalLogHandler = true
                    
                };

            Client = new DiscordClient(config);

            //Client.Ready += OnClientReady();

            Client.UseInteractivity(new InteractivityConfiguration
            {
                Timeout = TimeSpan.FromMinutes(5)
            });

            var commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] {configJson.Prefix },
                EnableDms = false,
                EnableMentionPrefix = true,
            };

            CarrotCoin carrotCoin = new CarrotCoin();

            Client.MessageCreated += async (s, e) =>
            {
                carrotCoin.Government(e.Message.Content, e.Author.Id);
            };

            Commands = Client.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<amongus>();
            Commands.RegisterCommands<Sussy>();
            Commands.RegisterCommands<carrotpoints>();

            await Client.ConnectAsync();

            await Task.Delay(-1);
        }

        private Task OnClientReady(ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
