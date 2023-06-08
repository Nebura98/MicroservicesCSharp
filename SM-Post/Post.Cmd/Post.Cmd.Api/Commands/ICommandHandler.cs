namespace Post.Cmd.Api.Commands
{
    public interface ICommandHandler
    {
        Task HandleAsync(NewPostCommand command);
        Task HandleAsync(EditMessageComand command);
        Task HandleAsync(LikePostComand command);
        Task HandleAsync(AddCommentComand command);
        Task HandleAsync(EditCommentCommand command);
        Task HandleAsync(RemoveCommentCommand command);
        Task HandleAsync(DeletePostCommand command);
    }
}