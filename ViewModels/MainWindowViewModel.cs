
using System.Windows.Input;
using Avalonia.Controls;
using NQueensCamera.Views;
using ReactiveUI;

namespace NQueensCamera.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
   private string _title = "Página Inicial";

   public string Title
   {
      get { return _title; }
   }
   
   public ICommand OpenNewBasicMethodsWindowCommand { get; }
   public ICommand OpenNewGeneticAlgorithmsWindowCommand { get; }
   public ICommand OpenNewAboutTheSystemWindowCommand { get; }
   
   public MainWindowViewModel()
   {
      OpenNewBasicMethodsWindowCommand = ReactiveCommand.Create(() =>
      {
         new BasicMethodsWindow()
         {
            DataContext = new BasicMethodsViewModel()
         }.Show();
      });
      
      OpenNewGeneticAlgorithmsWindowCommand = ReactiveCommand.Create(() =>
      {
         new GeneticAlgorithmsWindow()
         {
            DataContext = new GeneticAlgorithmsViewModel()
         }.Show();
      });
      
      OpenNewAboutTheSystemWindowCommand = ReactiveCommand.Create(() =>
      {
         new AboutTheSystemWindow()
         {
            DataContext = new AboutTheSystemViewModel()
         }.Show();
      });
   }
   
}