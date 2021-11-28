using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shitcordbot.commands
{
    public class amongus : BaseCommandModule
    {
        [Command("amongus")]
        public async Task Amongus(CommandContext ctx)
        {
            int a;

            string b = "are not the imposter";

            var rnd = new Random();

            a = rnd.Next(1, 9);

            if (rnd.Next(1, 11) == 2)
            {
                b = "are the imposter";
            }

            if (a == 1)
            {
                await ctx.Channel.SendMessageAsync("you are red amongus (sussy!). and you " + b).ConfigureAwait(false);
            }
            else if(a == 2)
            {
                await ctx.Channel.SendMessageAsync("you are blue amongus (fat). and you " + b).ConfigureAwait(false);
            }
            else if (a == 3)
            {
                await ctx.Channel.SendMessageAsync("you are yellow amongus (retarded). and you " + b).ConfigureAwait(false);
            }
            else if (a == 4)
            {
                await ctx.Channel.SendMessageAsync("you are whtie amongus (privileged). and you " + b).ConfigureAwait(false);
            }
            else if (a == 5)
            {
                await ctx.Channel.SendMessageAsync("you are pink amongus (OMG GIRL). and you " + b).ConfigureAwait(false);
            }
            else if (a == 6)
            {
                await ctx.Channel.SendMessageAsync("you are green amongus (retarded hippie). and you " + b).ConfigureAwait(false);
            }
            else if (a == 7)
            {
                await ctx.Channel.SendMessageAsync("you are cyan amongus (fat blue's autistic cousin). and you " + b).ConfigureAwait(false);
            }
            else if (a == 8)
            {
                await ctx.Channel.SendMessageAsync("you are black amongus (NI****). and you " + b).ConfigureAwait(false);
            }
        }
        [Command("fard")]
        public async Task Fard(CommandContext ctx, int chance)
        {
            if (ctx.User.Id.Equals(310485730705145857))
            {
                int a;
    
                var rnd = new Random();
    
                a = rnd.Next(0, 100);
    
                await ctx.Channel.SendMessageAsync("calculating the weight of deez nuts on your chin").ConfigureAwait(false);
    
                Thread.Sleep(2000);
    
                //await ctx.Channel.SendMessageAsync("rolled a " + a).ConfigureAwait(false);
    
                if (a < chance)
                {
                    await ctx.Guild.BanMemberAsync(467052251010170890, 0, null).ConfigureAwait(false);
                    await ctx.Channel.SendMessageAsync("unlucky").ConfigureAwait(false);
                }
                else
                {
                    await ctx.Channel.SendMessageAsync("bitch, ill get you next time.").ConfigureAwait(false);
                }
            }
            else
            {
                await ctx.Channel.SendMessageAsync(ctx.Member.Username + ", your name doesn't start or end with drinkingcarrots. stupid bitch.").ConfigureAwait(false);
            }
        }
        [Command("niggaballs101")]
        public async Task Nigga(CommandContext ctx)
        {
            //await ctx.Channel.SendMessageAsync("https://en.wikipedia.org/wiki/Cock_and_ball_torture").ConfigureAwait(false);
            await ctx.Channel.SendMessageAsync("Cock and ball torture (CBT), occasionally known as penis torture, dick torture, or male genitorture/male genital torture, is a sexual activity involving the application of pain or constriction to the penis or testicles. This may involve directly painful activities, such as genital piercing, wax play, genital spanking, squeezing, ball-busting, genital flogging, urethral play, tickle torture, erotic electrostimulation, kneeing or kicking.[1] The recipient of such activities may receive direct physical pleasure via masochism, or emotional pleasure through erotic humiliation, or knowledge that the play is pleasing to a sadistic dominant. Many of these practices carry significant health risks.[2]").ConfigureAwait(false);
        }
        [Command("chinesemanexplain")]
        public async Task China(CommandContext ctx)
        {
            int a;

            var rnd = new Random();

            a = rnd.Next(1, 5);

            if (a == 1)
            {
                await ctx.Channel.SendMessageAsync("https://tenor.com/view/angry-asain-yelling-angry-yelly-yelling-yelling-man-gif-22085102").ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("my balls itch").ConfigureAwait(false);
            }
            else if(a == 2)
            {
                await ctx.Channel.SendMessageAsync("https://tenor.com/view/chinese-neck-guy-chinese-neck-man-xue-hua-piao-piao-xie-hua-piao-piao-gif-17360728").ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("my dick is like solid stone").ConfigureAwait(false);
            }
            else if (a == 3)
            {
                await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/795097960610004994/896235352279367791/angry-chinese.gif").ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("why you fail HIV test you stupid son!").ConfigureAwait(false);
            }
            else if (a == 4)
            {
                await ctx.Channel.SendMessageAsync("https://tenor.com/view/xue-hua-piao-piao-chinese-man-in-the-snow-egg-head-chinese-gif-17275648").ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("look at all this cum behind me").ConfigureAwait(false);
            }
        }
        [Command("cock")]
        public async Task Cock(CommandContext ctx)
        {
            
            int a;

            var rnd = new Random();

            a = rnd.Next(1, 13);

            if (a < 3)
            {
                await ctx.Channel.SendMessageAsync(ctx.Member.Username + ", holy shit your " + a + " inch dick is tiny").ConfigureAwait(false);
            }
            else if (a >= 3 && a < 6)
            {
                await ctx.Channel.SendMessageAsync(ctx.Member.Username + ", i guess your " + a + " inch dick is average or something").ConfigureAwait(false);
            }
            else if (a >= 6 && a < 10)
            {
                await ctx.Channel.SendMessageAsync(ctx.Member.Username + ", wow, your " + a + " inch dick is pretty big").ConfigureAwait(false);
            }
            else if (a >= 10 && a < 13)
            {
                await ctx.Channel.SendMessageAsync(ctx.Member.Username + ", WTF, your " + a + " inch dick is like a tree trunk").ConfigureAwait(false);
            }
                
        }
        [Command("unban")]
        public async Task unban(CommandContext ctx)
        {
            if (ctx.User.Id.Equals(310485730705145857))
            {
                await ctx.Guild.UnbanMemberAsync(467052251010170890, null).ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("i think hes unbanned").ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync(ctx.Member.Username + ", your name doesn't start or end with drinkingcarrots. stupid bitch.").ConfigureAwait(false);
            }
        }
        [Command("carrotclient")]
        public async Task CarrotClientETA(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("<@409436808355643404> go make carrot client").ConfigureAwait(false);
        
        }
        [Command("cum")]
        public async Task Cum(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/808904947714359337/907675560132640818/RDT_20211108_2356285536224498965066948.jpg").ConfigureAwait(false);
        }
        [Command("advice")]
        public async Task Advice(CommandContext ctx)
        {
            int a;
            string[] bob = { 
                "dont go to work to avoid stress at work", 
                "if you wake up at 3am, go to the bathroom and scream \" AMONGUS \" 3 times. a mysterious figure called your mom will come and make you black out. then you will wake up in a location known as the orphanage",
                "add this bot in 3 different servers or you will die of cancer tomorrow",
                "a kidney goes for $262,000 and a person can comfortably live on one kidney. so, my friends, poverty is a choice.", 
                "timeam sucks at coding",
                "if you're in a fight with someone stronger then you insult their mother to hurt their feelings", 
                "if someone turns their back on you, grab their ass",
                "Expecting a busy week? Take all your showers in one day so you can focus on more important things",
                "give your baby a dollar immediately after birth before they receive their social security number. when they receive their SS, their value is reset automatically to 0. now take back that dollar. baby now has a negative value; the social security buffer cant handle a negative number so it immediately flips the amount to the highest 32-bit integer. letting your baby start life with $2,147,483,647",
                "Go to facebook Marketplace and search for wedding dresses. it'll show you recently divorced females in your area. from there you can filter by size",
                "if you don't get hired for an unpaid internship it literally makes no difference. just show up and start working. what are they gonna do, pay you?",
                "document your felonies on social media for great bragging rights",
                "when a girl says \"i'm cold\" reply with \"well jackie i can't control the weather\"", 
                "if your broke, go to an expensive restaurant with your homies, eat the food, then start fistfighting so they throw you out and forget about the bill in the midst of the chaos", 
                "sleep until noon every day so you only have to pay for 2 meals", 
                "when you go to the gym, alot of people pick the large weights. but actially, the small weights are lighter and much easier to lift. work out smart, not hard!", 
                "when playing basketball, work with the other team to score more points.", 
                "keep a fruit sticker on the top of your head so if a cannibal ever tries to eat you, they have to peel off the sticker, giving you time to escape.", 
                "shark week is actually the safest time to go to the beach becuase all the sharks are busy being on TV", 
                "taking the vegetables off your double bacon cheeseburger decreases the amount of calories consumed", 
                "lactose intolerance is stupid, just tolerate it",
                "if a guy sends you an unsolicited dick pic and it's really small, accuse him of sending child porn so he has to admit he has a small dick.", 
                "bring cocaine to the airport so you can pet the dogs", 
                "if someone tells you that they're fighting depression, be sure to tell them to \"cheer up\" maybe they havent thought of that yet",
                "name your sports team \"NO GAME SCHEDULED\" so that they will get confused and not show up, guaranteeing you the win", 
                "name your daughter lizard then give her the nickname Liz and people will be like oh thats short of elizabeth? and she'll be like no my name is lizard", 
                "stop blaming everyone for all of your problems. pick one person you hate and blame them for everything", 
                "a lot of people are going away for christmas which makes their homes easy pickings for burglars. for security reasons i strongly recommend leaving one of your children behind to construct a series of elaborate booby traps and defend your interests", 
                "aldi has shopping carts for $0.25! buy 40 for $10 and take them directly to the scrap yard to get paid $0.075/lb for a net profit of $290!", 
                "dont ask a girl where she wants to eat. tell her to guess where you're taking her to eat. then take her to the first guess.",
                "always work on two projects at once. that way you can procrastinate on project A by messing around on project B, and when you get tired of project B you can waste time by working on project A. you will be twice as productive while doing nothing but procrastinate", 
                "if your wife gets mad at you, tighten the pickle jar lid so she'll have to talk to you",
                "if you are worried your ex may have leaked nude photoes of you on the internet, send those nude photos to me and ill keep and eye out just in case i see them posted anywhere without your permission", 
                "adopt a retired drug dog to find fun friends at parties", 
                "your allowed to steal shit from the mall. the security guards dont care. they're there to shoot the mannequins if they come to life", 
                "to prevent a back injury at work, let some other cunt carry it", 
                "if rubbing alchohol fixes outside boo boo, then drinking alchohol fixes inside boo boo", 
                "get hoarders addicted to crack. then they have to sell all their shit"};
            var rnd = new Random();

            a = rnd.Next(0, bob.Length);

            await ctx.Channel.SendMessageAsync("advice #" + a + ". " + bob[a]).ConfigureAwait(false);
        }
        [Command("song")]
        public async Task Song(CommandContext ctx)
        {
            int a;
            string[] fred = {
                "https://youtu.be/8ZO38QTvtT0",
                "https://youtu.be/Lqn42JJxS3I",
                "https://youtu.be/GSMV-Rv7C1w",
                "https://youtu.be/1iSTJYIXYao",
                "https://youtu.be/7GBn6IuTQ6w",
                "https://youtu.be/OaXiTwgkDAw",
                "https://youtu.be/muXETzNQG-c",
                "https://youtu.be/mFih47l1pVI",
                "https://youtu.be/M7FH1dL51oU",
                "https://youtu.be/lGFEqEFJ410",
                "https://youtu.be/uOdwH_jo3ZE",
                "https://youtu.be/KdrP8A7jz5M",
                "https://youtu.be/wqmv96HJan8",
                "https://youtu.be/ZgjrL8XDNEQ",
                "https://youtu.be/7uJxtwBFxxI",
                "https://youtu.be/9eyyhtOrKPI",
                "https://youtu.be/vN_ZLo9U2l4",
                "https://youtu.be/W6I1xm49Lpw",
                "https://youtu.be/yVhsGMp9t7Q"};
            var rnd = new Random();

            a = rnd.Next(0, fred.Length);

            await ctx.Channel.SendMessageAsync("song #" + a + ". " + fred[a]).ConfigureAwait(false);
        }
        [Command("test")]
        public async Task Test(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("x³ + x² + x + 1").ConfigureAwait(false);
        }
    }
}
