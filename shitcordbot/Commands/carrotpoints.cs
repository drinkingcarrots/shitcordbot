using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using shitcordbot.Points;

namespace shitcordbot.Commands
{
    public class carrotpoints : BaseCommandModule
    {
        CarrotCoin carrotCoin = new CarrotCoin();

        [Command("mysocialcredit")]
        [Aliases("mycredit", "mysocial", "msc")]
        public async Task PointCheck(CommandContext ctx)
        {
            string userPoints = Convert.ToString(Math.Round(carrotCoin.PointFinder(ctx.Member.Id)));

            if (userPoints != "-1000000")
            {
                await ctx.Channel.SendMessageAsync(userPoints).ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("no profile located, create a profile wtih ?createprofile.").ConfigureAwait(false);
            }
            
        }
        [Command("socialcredit")]
        [Aliases("credit", "social", "sc")]
        public async Task ElsePointCheck(CommandContext ctx, string At)
        {
            string userPoints = Convert.ToString(Math.Round(carrotCoin.PointFinder(carrotCoin.AtToId(At))));

            if (userPoints != "-1000000")
            {
                await ctx.Channel.SendMessageAsync(userPoints).ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("they dont have a profile (sadge)").ConfigureAwait(false);
            }

        }
        [Command("createprofile")]
        public async Task ProfileCreate(CommandContext ctx)
        {
            bool created = carrotCoin.ProfileCreater(ctx.Member.Id);

            if (created == true)
            {
                await ctx.Channel.SendMessageAsync("created").ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync("you already have a profile").ConfigureAwait(false);
            }
        }
        //[Command("addsocialcredit")]
        //[Aliases("add", "addsocial", "addcredit", "asc")]
        //[RequireRoles(RoleCheckMode.Any, "me")]
        //public async Task ProfileCreate(CommandContext ctx, string member, string amount)
        //{
        //    ulong user = carrotCoin.AtToId(member);
        //    
        //    long points = Convert.ToInt64(amount);
        //    
        //    bool changed = carrotCoin.PointChange(user, points);
        //    if(changed == true)
        //    {
        //        await ctx.Channel.SendMessageAsync("changed").ConfigureAwait(false);
        //    }
        //    else
        //    {
        //        await ctx.Channel.SendMessageAsync("no profile").ConfigureAwait(false);
        //    }
        //    
        //}
    }
}
