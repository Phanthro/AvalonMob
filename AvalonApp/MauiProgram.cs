using AvalonApp.CustomControls;
using AvalonApp.Platforms;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AvalonApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts( fonts =>
                {
                    fonts.AddFont( "OpenSans-Regular.ttf", "OpenSansRegular" );
                    fonts.AddFont( "OpenSans-Semibold.ttf", "OpenSansSemibold" );
                    fonts.AddFont( "Outfit-Regular.ttf", "OutfitRegular" );
                    fonts.AddFont( "Outfit-Bold.ttf", "OutfitBold" );
                    fonts.AddFont( "Inter-Bold.ttf", "InterBold" );
                    fonts.AddFont( "Inter-ExtraBold.ttf", "InterExtraBold" );
                } )
                .UseMauiMaps()
                .UseMauiCommunityToolkit();


            Microsoft.Maui.Handlers.ElementHandler.ElementMapper.AppendToMapping( "Classic", ( handler, view ) =>
            {
                if(view is StandardEntry)
                {
                    EntryMapper.Map(handler, view);
                }
            } );

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
