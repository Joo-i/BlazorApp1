namespace BlazorApp2.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        [Parameter] public int Step { get; set; } = 1;
        [Parameter] public int InitialCount { get; set; } = 1;
        [Parameter] public RenderFragment? ChildContent { get; set; }
        [Parameter] public RenderFragment? SecondChildContent { get; set; }
        [Parameter] public string title { get; set; } = "Counter Page";  
        [Parameter] public string? key { get; set; } = "Counter";

        //protected override void OnInitialized()
        //{
        //    base.OnInitialized();

        //    currentCount = InitialCount;
        //}

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (CounterService.GetCount(key!) == 0 && InitialCount > 0)
            {
                CounterService.SetCount(key!, InitialCount);
            }

                currentCount = CounterService.GetCount(key!);
        } 


        private void IncrementCount()
        {  
           CounterService.IncrementCount(key!, Step);

            currentCount = CounterService.GetCount(key!);
        }
    }

}
