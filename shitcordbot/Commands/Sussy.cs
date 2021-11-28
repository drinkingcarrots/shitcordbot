using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity.Extensions;
using DSharpPlus.Interactivity.EventHandling;
using DSharpPlus.Interactivity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace shitcordbot
{
    class Sussy : BaseCommandModule
    {
        [Command("math")]
        public async Task Math(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var rnd = new Random();

            int a, b, c;

            c = rnd.Next(1, 5);

            if (c == 1)
            {
                a = rnd.Next(0, 100);
                b = rnd.Next(0, 100);

                await ctx.Channel.SendMessageAsync("what is " + a + " + " + b + "?").ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == a + b)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (c == 2)
            {
                a = rnd.Next(1, 17);
                b = rnd.Next(1, 17);

                await ctx.Channel.SendMessageAsync("what is " + a + " x " + b + "?").ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == a * b)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (c == 3)
            {
                b = rnd.Next(0, 100);
                a = rnd.Next(0, 100);

                await ctx.Channel.SendMessageAsync("what is " + a + " - " + b + "?").ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == a - b)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (c == 4)
            {
                a = rnd.Next(1, 10000);
                b = rnd.Next(1, 10000);

                await ctx.Channel.SendMessageAsync("what is " + a + " / " + b + "? (rounded)").ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == Convert.ToInt32(MathF.Round(a / b)))
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
        [Command("hardmath")]
        public async Task HardMath(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var rnd = new Random();

            int a, b, c;

            c = rnd.Next(1, 5);

            if (c == 1)
            {
                a = rnd.Next(0, 1000);
                b = rnd.Next(0, 1000);

                await ctx.Channel.SendMessageAsync("what is " + a + " + " + b + "?").ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == a + b)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (c == 2)
            {
                a = rnd.Next(8, 65);
                b = rnd.Next(8, 65);

                await ctx.Channel.SendMessageAsync("what is " + a + " x " + b + "?").ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == a * b)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (c == 3)
            {
                a = rnd.Next(0, 1000);
                b = rnd.Next(0, 1000);

                await ctx.Channel.SendMessageAsync("what is " + a + " - " + b + "?").ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == a - b)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (c == 4)
            {
                a = rnd.Next(1, 1000000);
                b = rnd.Next(1, 1000000);
                int d;
                await ctx.Channel.SendMessageAsync("what is " + a + " / " + b + "? (rounded)").ConfigureAwait(false);
                d = (int)MathF.Round(a / b);
                d = Convert.ToInt32(d);
                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == d)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
        [Command("reallyhardmath")]
        public async Task ReallyHardMath(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            int x, a, b, c, d, r;
            var rnd = new Random();
            r = rnd.Next(1, 3);
            if(r == 1)
            {
                x = rnd.Next(-3, 4);
                a = rnd.Next(-5, 6);
                b = rnd.Next(-5, 6);
                c = rnd.Next(-5, 6);
                d = rnd.Next(-5, 6);

                await ctx.Channel.SendMessageAsync("synthetic division time! Find the remainder").ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("`x = " + x + "  |   " + a + "   " + b + "   " + c + "   " + d + "`").ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("`       |___________________`").ConfigureAwait(false);

                a = a;
                b = (x * a) + b;
                c = (x * b) + c;
                d = (x * c) + d;

                //await ctx.Channel.SendMessageAsync(Convert.ToString(d)).ConfigureAwait(false);
                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == d)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (r == 2)
            {
                a = rnd.Next(1, 6);
                b = rnd.Next(1, 6);
                c = rnd.Next(1, 6);

                d = ((a + b) * c) + (a * b);

                if (a == b)
                {
                    r = a + c;
                }
                else if ( b == c)
                {
                    r = b + a;
                }
                else if ( a == c)
                {
                    r = a + b;
                }
                else
                {
                    r = a + b + c;
                }
                await ctx.Channel.SendMessageAsync("add all the zeros ( a + b + c )").ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("0 = x³ " + ((-a) - b - c) + "x² +" + d + "x -" + a * b * c).ConfigureAwait(false);

                while (true)
                {
                    var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
                    try
                    {
                        if (Convert.ToInt32(message.Result.Content) == r)
                        {
                            await ctx.Channel.SendMessageAsync(message.Result.Author.Username + " wins!").ConfigureAwait(false);
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            else if (r == 3)
            {

            }
        }
    }
}
