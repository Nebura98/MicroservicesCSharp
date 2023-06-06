using CQRS.Core.Commands;


namespace Post.Cmd.Api.Commands
{
    public class EditMessageComand : BaseCommand
    {
        public string Message { get; set; }
    }
}