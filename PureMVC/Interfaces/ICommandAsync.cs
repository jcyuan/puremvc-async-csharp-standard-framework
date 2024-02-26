//
//  PureMVC C# Standard
//
//  Copyright(c) 2020 Saad Shams <saad.shams@puremvc.org>
//  Your reuse is governed by the Creative Commons Attribution 3.0 License
//

using System.Threading.Tasks;

namespace PureMVC.Interfaces
{
    /// <summary>
    /// The interface definition for a PureMVC Command.
    /// </summary>
    /// <seealso cref="INotification"/>
    public interface ICommandAsync: INotifier
    {
        /// <summary>
        /// Execute the <c>ICommand</c>'s logic to handle a given <c>INotification</c>.
        /// </summary>
        /// <param name="notification">an <c>INotification</c> to handle.</param>
        Task ExecuteAsync(INotification notification);
    }
}
