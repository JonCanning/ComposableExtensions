// Generated with ComposableExtensions (0.11.0) http://jbtule.github.io/ComposableExtensions

namespace Composable.Linq
/// Corresponding static methods as functions for [`System.Linq.Enumerable`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable)
module Enumerable =

    /// Calls [`Aggregate(source, System.Func<'TSource, 'TSource, 'TSource>(func))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.aggregate)
    let inline aggregate (func:'TSource->'TSource->'TSource) source = System.Linq.Enumerable.Aggregate(source, System.Func<'TSource, 'TSource, 'TSource>(func))

    /// Calls [`All(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.all)
    let inline all (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.All(source, System.Func<'TSource, System.Boolean>(predicate))

    /// Calls [`Any(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.any)
    let inline any source = System.Linq.Enumerable.Any(source)

    /// Calls [`AsEnumerable(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.asenumerable)
    let inline asEnumerable source = System.Linq.Enumerable.AsEnumerable(source)

    /// Calls [`Cast<'TResult>(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.cast)
    let inline cast<'TResult> source = System.Linq.Enumerable.Cast<'TResult>(source)

    /// Calls [`Concat(first, second)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.concat)
    let inline concat first second = System.Linq.Enumerable.Concat(first, second)

    /// Calls [`Contains(source, value)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.contains)
    let inline contains value source = System.Linq.Enumerable.Contains(source, value)

    /// Calls [`Count(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.count)
    let inline count source = System.Linq.Enumerable.Count(source)

    /// Calls [`DefaultIfEmpty(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.defaultifempty)
    let inline defaultIfEmpty source = System.Linq.Enumerable.DefaultIfEmpty(source)

    /// Calls [`Distinct(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.distinct)
    let inline distinct source = System.Linq.Enumerable.Distinct(source)

    /// Calls [`ElementAt(source, index)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.elementat)
    let inline elementAt index source = System.Linq.Enumerable.ElementAt(source, index)

    /// Calls [`ElementAtOrDefault(source, index)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.elementatordefault)
    let inline elementAtOrDefault index source = System.Linq.Enumerable.ElementAtOrDefault(source, index)

    /// Calls [`Except(first, second)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.except)
    let inline except second first = System.Linq.Enumerable.Except(first, second)

    /// Calls [`First(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.first)
    let inline first source = System.Linq.Enumerable.First(source)

    /// Calls [`FirstOrDefault(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.firstordefault)
    let inline firstOrDefault source = System.Linq.Enumerable.FirstOrDefault(source)

    /// Calls [`GroupBy(source, System.Func<'TSource, 'TKey>(keySelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.groupby)
    let inline groupBy (keySelector:'TSource->'TKey) source = System.Linq.Enumerable.GroupBy(source, System.Func<'TSource, 'TKey>(keySelector))

    /// Calls [`GroupJoin(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, System.Collections.Generic.IEnumerable<'TInner>, 'TResult>(resultSelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.groupjoin)
    let inline groupJoin (outerKeySelector:'TOuter->'TKey) (innerKeySelector:'TInner->'TKey) (resultSelector:'TOuter->System.Collections.Generic.IEnumerable<'TInner>->'TResult) outer inner = System.Linq.Enumerable.GroupJoin(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, System.Collections.Generic.IEnumerable<'TInner>, 'TResult>(resultSelector))

    /// Calls [`Intersect(first, second)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.intersect)
    let inline intersect first second = System.Linq.Enumerable.Intersect(first, second)

    /// Calls [`Join(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, 'TInner, 'TResult>(resultSelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.join)
    let inline join (outerKeySelector:'TOuter->'TKey) (innerKeySelector:'TInner->'TKey) (resultSelector:'TOuter->'TInner->'TResult) outer inner = System.Linq.Enumerable.Join(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, 'TInner, 'TResult>(resultSelector))

    /// Calls [`Last(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.last)
    let inline last source = System.Linq.Enumerable.Last(source)

    /// Calls [`LastOrDefault(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.lastordefault)
    let inline lastOrDefault source = System.Linq.Enumerable.LastOrDefault(source)

    /// Calls [`LongCount(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.longcount)
    let inline longCount source = System.Linq.Enumerable.LongCount(source)

    /// Calls [`OfType<'TResult>(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.oftype)
    let inline ofType<'TResult> source = System.Linq.Enumerable.OfType<'TResult>(source)

    /// Calls [`OrderBy(source, System.Func<'TSource, 'TKey>(keySelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.orderby)
    let inline orderBy (keySelector:'TSource->'TKey) source = System.Linq.Enumerable.OrderBy(source, System.Func<'TSource, 'TKey>(keySelector))

    /// Calls [`OrderByDescending(source, System.Func<'TSource, 'TKey>(keySelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.orderbydescending)
    let inline orderByDescending (keySelector:'TSource->'TKey) source = System.Linq.Enumerable.OrderByDescending(source, System.Func<'TSource, 'TKey>(keySelector))

    /// Calls [`Reverse(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.reverse)
    let inline reverse source = System.Linq.Enumerable.Reverse(source)

    /// Calls [`Select(source, System.Func<'TSource, 'TResult>(selector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.select)
    let inline select (selector:'TSource->'TResult) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.Select(source, System.Func<'TSource, 'TResult>(selector))

    /// Calls [`SelectMany(source, System.Func<'TSource, System.Collections.Generic.IEnumerable<'TResult>>(selector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.selectmany)
    let inline selectMany (selector:'TSource->System.Collections.Generic.IEnumerable<'TResult>) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.SelectMany(source, System.Func<'TSource, System.Collections.Generic.IEnumerable<'TResult>>(selector))

    /// Calls [`SequenceEqual(first, second)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.sequenceequal)
    let inline sequenceEqual first second = System.Linq.Enumerable.SequenceEqual(first, second)

    /// Calls [`Single(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.single)
    let inline single source = System.Linq.Enumerable.Single(source)

    /// Calls [`SingleOrDefault(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.singleordefault)
    let inline singleOrDefault source = System.Linq.Enumerable.SingleOrDefault(source)

    /// Calls [`Skip(source, count)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.skip)
    let inline skip count source = System.Linq.Enumerable.Skip(source, count)

    /// Calls [`SkipWhile(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.skipwhile)
    let inline skipWhile (predicate:'TSource->System.Boolean) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.SkipWhile(source, System.Func<'TSource, System.Boolean>(predicate))

    /// Calls [`Take(source, count)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.take)
    let inline take count source = System.Linq.Enumerable.Take(source, count)

    /// Calls [`TakeWhile(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.takewhile)
    let inline takeWhile (predicate:'TSource->System.Boolean) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.TakeWhile(source, System.Func<'TSource, System.Boolean>(predicate))

    /// Calls [`ThenBy(source, System.Func<'TSource, 'TKey>(keySelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.thenby)
    let inline thenBy (keySelector:'TSource->'TKey) source = System.Linq.Enumerable.ThenBy(source, System.Func<'TSource, 'TKey>(keySelector))

    /// Calls [`ThenByDescending(source, System.Func<'TSource, 'TKey>(keySelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.thenbydescending)
    let inline thenByDescending (keySelector:'TSource->'TKey) source = System.Linq.Enumerable.ThenByDescending(source, System.Func<'TSource, 'TKey>(keySelector))

    /// Calls [`ToArray(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.toarray)
    let inline toArray source = System.Linq.Enumerable.ToArray(source)

    /// Calls [`ToDictionary(source, System.Func<'TSource, 'TKey>(keySelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.todictionary)
    let inline toDictionary (keySelector:'TSource->'TKey) source = System.Linq.Enumerable.ToDictionary(source, System.Func<'TSource, 'TKey>(keySelector))

    /// Calls [`ToList(source)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.tolist)
    let inline toList source = System.Linq.Enumerable.ToList(source)

    /// Calls [`ToLookup(source, System.Func<'TSource, 'TKey>(keySelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.tolookup)
    let inline toLookup (keySelector:'TSource->'TKey) source = System.Linq.Enumerable.ToLookup(source, System.Func<'TSource, 'TKey>(keySelector))

    /// Calls [`Union(first, second)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.union)
    let inline union first second = System.Linq.Enumerable.Union(first, second)

    /// Calls [`Where(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.where)
    let inline where (predicate:'TSource->System.Boolean) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.Where(source, System.Func<'TSource, System.Boolean>(predicate))

    /// Longer parameter versions of `System.Linq.Enumerable` methods
    module Full =

        /// Calls [`Aggregate(source, seed, System.Func<'TAccumulate, 'TSource, 'TAccumulate>(func), System.Func<'TAccumulate, 'TResult>(resultSelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.aggregate)
        let inline aggregate seed (func:'TAccumulate->'TSource->'TAccumulate) (resultSelector:'TAccumulate->'TResult) source = System.Linq.Enumerable.Aggregate(source, seed, System.Func<'TAccumulate, 'TSource, 'TAccumulate>(func), System.Func<'TAccumulate, 'TResult>(resultSelector))

        /// Calls [`Any(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.any)
        let inline any (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.Any(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`Contains(source, value, comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.contains)
        let inline contains value comparer source = System.Linq.Enumerable.Contains(source, value, comparer)

        /// Calls [`Count(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.count)
        let inline count (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.Count(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`DefaultIfEmpty(source, defaultValue)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.defaultifempty)
        let inline defaultIfEmpty defaultValue source = System.Linq.Enumerable.DefaultIfEmpty(source, defaultValue)

        /// Calls [`Distinct(source, comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.distinct)
        let inline distinct comparer source = System.Linq.Enumerable.Distinct(source, comparer)

        /// Calls [`Except(first, second, comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.except)
        let inline except second comparer first = System.Linq.Enumerable.Except(first, second, comparer)

        /// Calls [`First(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.first)
        let inline first (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.First(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`FirstOrDefault(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.firstordefault)
        let inline firstOrDefault (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.FirstOrDefault(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`GroupBy(source, System.Func<'TSource, 'TKey>(keySelector), System.Func<'TSource, 'TElement>(elementSelector), System.Func<'TKey, System.Collections.Generic.IEnumerable<'TElement>, 'TResult>(resultSelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.groupby)
        let inline groupBy (keySelector:'TSource->'TKey) (elementSelector:'TSource->'TElement) (resultSelector:'TKey->System.Collections.Generic.IEnumerable<'TElement>->'TResult) comparer source = System.Linq.Enumerable.GroupBy(source, System.Func<'TSource, 'TKey>(keySelector), System.Func<'TSource, 'TElement>(elementSelector), System.Func<'TKey, System.Collections.Generic.IEnumerable<'TElement>, 'TResult>(resultSelector), comparer)

        /// Calls [`GroupJoin(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, System.Collections.Generic.IEnumerable<'TInner>, 'TResult>(resultSelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.groupjoin)
        let inline groupJoin (outerKeySelector:'TOuter->'TKey) (innerKeySelector:'TInner->'TKey) (resultSelector:'TOuter->System.Collections.Generic.IEnumerable<'TInner>->'TResult) comparer outer inner = System.Linq.Enumerable.GroupJoin(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, System.Collections.Generic.IEnumerable<'TInner>, 'TResult>(resultSelector), comparer)

        /// Calls [`Intersect(first, second, comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.intersect)
        let inline intersect comparer first second = System.Linq.Enumerable.Intersect(first, second, comparer)

        /// Calls [`Join(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, 'TInner, 'TResult>(resultSelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.join)
        let inline join (outerKeySelector:'TOuter->'TKey) (innerKeySelector:'TInner->'TKey) (resultSelector:'TOuter->'TInner->'TResult) comparer outer inner = System.Linq.Enumerable.Join(outer, inner, System.Func<'TOuter, 'TKey>(outerKeySelector), System.Func<'TInner, 'TKey>(innerKeySelector), System.Func<'TOuter, 'TInner, 'TResult>(resultSelector), comparer)

        /// Calls [`Last(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.last)
        let inline last (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.Last(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`LastOrDefault(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.lastordefault)
        let inline lastOrDefault (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.LastOrDefault(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`LongCount(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.longcount)
        let inline longCount (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.LongCount(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`OrderBy(source, System.Func<'TSource, 'TKey>(keySelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.orderby)
        let inline orderBy (keySelector:'TSource->'TKey) comparer source = System.Linq.Enumerable.OrderBy(source, System.Func<'TSource, 'TKey>(keySelector), comparer)

        /// Calls [`OrderByDescending(source, System.Func<'TSource, 'TKey>(keySelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.orderbydescending)
        let inline orderByDescending (keySelector:'TSource->'TKey) comparer source = System.Linq.Enumerable.OrderByDescending(source, System.Func<'TSource, 'TKey>(keySelector), comparer)

        /// Calls [`Select(source, System.Func<'TSource, System.Int32, 'TResult>(selector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.select)
        let inline select (selector:'TSource->System.Int32->'TResult) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.Select(source, System.Func<'TSource, System.Int32, 'TResult>(selector))

        /// Calls [`SelectMany(source, System.Func<'TSource, System.Int32, System.Collections.Generic.IEnumerable<'TCollection>>(collectionSelector), System.Func<'TSource, 'TCollection, 'TResult>(resultSelector))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.selectmany)
        let inline selectMany (collectionSelector:'TSource->System.Int32->System.Collections.Generic.IEnumerable<'TCollection>) (resultSelector:'TSource->'TCollection->'TResult) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.SelectMany(source, System.Func<'TSource, System.Int32, System.Collections.Generic.IEnumerable<'TCollection>>(collectionSelector), System.Func<'TSource, 'TCollection, 'TResult>(resultSelector))

        /// Calls [`SequenceEqual(first, second, comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.sequenceequal)
        let inline sequenceEqual comparer first second = System.Linq.Enumerable.SequenceEqual(first, second, comparer)

        /// Calls [`Single(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.single)
        let inline single (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.Single(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`SingleOrDefault(source, System.Func<'TSource, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.singleordefault)
        let inline singleOrDefault (predicate:'TSource->System.Boolean) source = System.Linq.Enumerable.SingleOrDefault(source, System.Func<'TSource, System.Boolean>(predicate))

        /// Calls [`SkipWhile(source, System.Func<'TSource, System.Int32, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.skipwhile)
        let inline skipWhile (predicate:'TSource->System.Int32->System.Boolean) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.SkipWhile(source, System.Func<'TSource, System.Int32, System.Boolean>(predicate))

        /// Calls [`TakeWhile(source, System.Func<'TSource, System.Int32, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.takewhile)
        let inline takeWhile (predicate:'TSource->System.Int32->System.Boolean) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.TakeWhile(source, System.Func<'TSource, System.Int32, System.Boolean>(predicate))

        /// Calls [`ThenBy(source, System.Func<'TSource, 'TKey>(keySelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.thenby)
        let inline thenBy (keySelector:'TSource->'TKey) comparer source = System.Linq.Enumerable.ThenBy(source, System.Func<'TSource, 'TKey>(keySelector), comparer)

        /// Calls [`ThenByDescending(source, System.Func<'TSource, 'TKey>(keySelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.thenbydescending)
        let inline thenByDescending (keySelector:'TSource->'TKey) comparer source = System.Linq.Enumerable.ThenByDescending(source, System.Func<'TSource, 'TKey>(keySelector), comparer)

        /// Calls [`ToDictionary(source, System.Func<'TSource, 'TKey>(keySelector), System.Func<'TSource, 'TElement>(elementSelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.todictionary)
        let inline toDictionary (keySelector:'TSource->'TKey) (elementSelector:'TSource->'TElement) comparer source = System.Linq.Enumerable.ToDictionary(source, System.Func<'TSource, 'TKey>(keySelector), System.Func<'TSource, 'TElement>(elementSelector), comparer)

        /// Calls [`ToLookup(source, System.Func<'TSource, 'TKey>(keySelector), System.Func<'TSource, 'TElement>(elementSelector), comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.tolookup)
        let inline toLookup (keySelector:'TSource->'TKey) (elementSelector:'TSource->'TElement) comparer source = System.Linq.Enumerable.ToLookup(source, System.Func<'TSource, 'TKey>(keySelector), System.Func<'TSource, 'TElement>(elementSelector), comparer)

        /// Calls [`Union(first, second, comparer)`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.union)
        let inline union comparer first second = System.Linq.Enumerable.Union(first, second, comparer)

        /// Calls [`Where(source, System.Func<'TSource, System.Int32, System.Boolean>(predicate))`](http://msdn.microsoft.com/en-us/library/system.linq.enumerable.where)
        let inline where (predicate:'TSource->System.Int32->System.Boolean) (source:System.Collections.Generic.IEnumerable<'TSource>) = System.Linq.Enumerable.Where(source, System.Func<'TSource, System.Int32, System.Boolean>(predicate))
