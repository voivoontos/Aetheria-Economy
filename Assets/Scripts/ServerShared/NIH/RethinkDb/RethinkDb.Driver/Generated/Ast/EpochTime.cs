














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

    public partial class EpochTime : ReqlExpr {

    
    
    
/// <summary>
/// <para>Create a time object based on seconds since epoch. The first argument is a double and
/// will be rounded to three decimal places (millisecond-precision).</para>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986.</para>
/// <code>r.table("user").get("John").update({birthdate: r.epochTime(531360000)}).run(conn, callback)
/// </code></example>
        public EpochTime (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Create a time object based on seconds since epoch. The first argument is a double and
/// will be rounded to three decimal places (millisecond-precision).</para>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986.</para>
/// <code>r.table("user").get("John").update({birthdate: r.epochTime(531360000)}).run(conn, callback)
/// </code></example>
        public EpochTime (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Create a time object based on seconds since epoch. The first argument is a double and
/// will be rounded to three decimal places (millisecond-precision).</para>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986.</para>
/// <code>r.table("user").get("John").update({birthdate: r.epochTime(531360000)}).run(conn, callback)
/// </code></example>
        public EpochTime (Arguments args, OptArgs optargs)
         : base(TermType.EPOCH_TIME, args, optargs) {
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