using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CalculatorAvalonia.ViewModels;
using StringMath;

namespace CalculatorAvalonia.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public void OpeningParenthesisClicked(object sender, RoutedEventArgs args)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("(");
            viewModel.ChangeEquation();
        }
    }
    
    private void ClosingParenthesisClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push(")");
            viewModel.ChangeEquation();
        }
    }

    private void DivisionClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.BeforeChangeEquation();
            viewModel.CurrentEquation.Push("/");
            viewModel.ChangeEquation();
        }
    }

    private void BackspaceClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            if (viewModel.CurrentEquation.Count > 0)
            {
                viewModel.ResetResultEquation();
                viewModel.CurrentEquation.Pop();
                viewModel.ChangeEquation();
            }
        }
    }

    private void SevenClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("7");
            viewModel.ChangeEquation();
        }
    }

    private void EightClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("8");
            viewModel.ChangeEquation();
        }
    }

    private void NineClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("9");
            viewModel.ChangeEquation();
        }
    }

    private void MultiplicationClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.BeforeChangeEquation();
            viewModel.CurrentEquation.Push("*");
            viewModel.ChangeEquation();
        }
    }

    private void FourClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("4");
            viewModel.ChangeEquation();
        }
    }

    private void FiveClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("5");
            viewModel.ChangeEquation();
        }
    }

    private void SixClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("6");
            viewModel.ChangeEquation();
        }
    }

    private void SubtractionClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.BeforeChangeEquation();
            viewModel.CurrentEquation.Push("-");
            viewModel.ChangeEquation();
        }
    }

    private void OneClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("1");
            viewModel.ChangeEquation();
        }
    }

    private void TwoClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("2");
            viewModel.ChangeEquation();
        }
    }

    private void ThreeClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("3");
            viewModel.ChangeEquation();
        }
    }

    private void AdditionClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.BeforeChangeEquation();
            viewModel.CurrentEquation.Push("+");
            viewModel.ChangeEquation();
        }
    }

    private void ClearClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.CurrentEquation.Clear();
            viewModel.ChangeEquation();
            
            viewModel.ResultEquationStr = "";
            viewModel.ChangeResultEquation();
        }
    }

    private void ZeroClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push("0");
            viewModel.ChangeEquation();
        }
    }

    private void DotClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            viewModel.CurrentEquation.Push(".");
            viewModel.ChangeEquation();
        }
    }

    private void EqualClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel && viewModel.CurrentEquation.Count < 24)
        {
            viewModel.ResetResultEquation();
            
            double result;
            
            try
            {
                result = viewModel.CurrentEquationStr.Eval();
                
                viewModel.CurrentEquation.Clear();
                viewModel.ChangeEquation();
            
                viewModel.ResultEquationStr = result.ToString();
                viewModel.ChangeResultEquation();
            }
            catch (Exception exception)
            {
                viewModel.ResultEquationStr = "Error";
                viewModel.ChangeResultEquation();
            }
        }
    }
}