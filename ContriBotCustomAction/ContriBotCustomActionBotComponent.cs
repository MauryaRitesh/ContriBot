﻿using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs.Declarative;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContriBotCustomAction
{
    public class ContriBotCustomActionBotComponent : BotComponent
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DeclarativeType>(sp =>
                new DeclarativeType<ContriBotCustomAction>(ContriBotCustomAction.Kind));
        }
    }
}
