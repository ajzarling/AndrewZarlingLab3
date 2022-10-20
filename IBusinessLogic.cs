using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Lab2Solution
{
    /// <summary>
    /// The interface for BusinessLogic
    /// </summary>
    public interface IBusinessLogic
    {
        InvalidFieldError AddEntry(string clue, string answer, int difficulty, string date);
        EntryDeletionError DeleteEntry(int entryId);
        EntryEditError EditEntry(string clue, string answer, int difficulty, string date, int id);
        Entry FindEntry(int id);
        ObservableCollection<Entry> GetEntries();
        void InvalidFieldErrorAddEntry(Entry entry);
    }
}