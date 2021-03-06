﻿using System.Threading.Tasks;
using CommunityBot.Features.Trivia;
using Discord.Commands;

namespace CommunityBot.Modules.Fun
{
    public class Trivia : ModuleBase<SocketCommandContext>
    {
        private readonly TriviaGames _triviaGames;

        Trivia(TriviaGames triviaGames)
        {
            _triviaGames = triviaGames;
        }

        [Command("Trivia", RunMode = RunMode.Async)]
        public async Task NewTrivia()
        {
            var msg = await Context.Channel.SendMessageAsync("", false, _triviaGames.TrivaStartingEmbed().Build());
            _triviaGames.NewTrivia(msg, Context.User);
        }                                       
    }
}
