














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Distinct : ReqlExpr {

    
    
    
/// <summary>
/// <para>Removes duplicates from elements in a sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by Marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Removes duplicates from elements in a sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by Marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Removes duplicates from elements in a sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by Marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (Arguments args, OptArgs optargs)
         : base(TermType.DISTINCT, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public Distinct this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Distinct (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "index": "T_STR"
///</summary>
    public Distinct this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Distinct (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "index": "T_STR"
///</summary>
        public Distinct OptArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Distinct (this.Args, newOptArgs);
        }
        internal Distinct optArg(string key, object val){
        
            return this.OptArg(key, val);
        }


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}