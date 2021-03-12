﻿// The MIT License(MIT)

// Copyright(c) 2021 Alberto Rodriguez Orozco & LiveCharts Contributors

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using LiveChartsCore.Drawing;
using LiveChartsCore.Sketches;
using LiveChartsCore.SkiaSharpView.Drawing;
using SkiaSharp;

namespace LiveChartsCore.SkiaSharpView
{
    public class StackedAreaSeries<TModel> : StackedAreaSeries<TModel, CircleGeometry, LabelGeometry>
    {

    }

    public class StackedAreaSeries<TModel, TVisual> : StackedAreaSeries<TModel, TVisual, LabelGeometry>
        where TVisual : class, ISizedVisualChartPoint<SkiaSharpDrawingContext>, new()
    {

    }

    public class StackedAreaSeries<TModel, TVisual, TLabel>
        : StackedAreaSeries<TModel, TVisual, TLabel, SkiaSharpDrawingContext, PathGeometry, LineSegment, CubicBezierSegment, MoveToPathCommand, SKPath>
        where TVisual : class, ISizedVisualChartPoint<SkiaSharpDrawingContext>, new()
        where TLabel : class, ILabelGeometry<SkiaSharpDrawingContext>, new()
    {
        public StackedAreaSeries()
        {
            if (!LiveCharts.IsConfigured) LiveCharts.Configure(LiveChartsSkiaSharp.DefaultPlatformBuilder);
            InitializeSeries();
        }
    }
}