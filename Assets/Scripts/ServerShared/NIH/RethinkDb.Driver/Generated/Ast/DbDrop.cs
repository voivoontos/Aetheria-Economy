














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

    public partial class DbDrop : ReqlExpr {

    
    
    
/// <summary>
/// <para>Drop a database. The database, all its tables, and corresponding data will be deleted.</para>
/// </summary>
/// <example><para>Example: Drop a database named 'superheroes'.</para>
/// <code>&gt; r.dbDrop('superheroes').run(conn, callback);
/// // Result passed to callback
/// {
///     "config_changes": [
///         {
///             "old_val": {
///                 "id": "e4689cfc-e903-4532-a0e6-2d6797a43f07",
///                 "name": "superheroes"
///             },
///             "new_val": null
///         }
///     ],
///     "tables_dropped": 3,
///     "dbs_dropped": 1
/// }
/// </code></example>
        public DbDrop (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Drop a database. The database, all its tables, and corresponding data will be deleted.</para>
/// </summary>
/// <example><para>Example: Drop a database named 'superheroes'.</para>
/// <code>&gt; r.dbDrop('superheroes').run(conn, callback);
/// // Result passed to callback
/// {
///     "config_changes": [
///         {
///             "old_val": {
///                 "id": "e4689cfc-e903-4532-a0e6-2d6797a43f07",
///                 "name": "superheroes"
///             },
///             "new_val": null
///         }
///     ],
///     "tables_dropped": 3,
///     "dbs_dropped": 1
/// }
/// </code></example>
        public DbDrop (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Drop a database. The database, all its tables, and corresponding data will be deleted.</para>
/// </summary>
/// <example><para>Example: Drop a database named 'superheroes'.</para>
/// <code>&gt; r.dbDrop('superheroes').run(conn, callback);
/// // Result passed to callback
/// {
///     "config_changes": [
///         {
///             "old_val": {
///                 "id": "e4689cfc-e903-4532-a0e6-2d6797a43f07",
///                 "name": "superheroes"
///             },
///             "new_val": null
///         }
///     ],
///     "tables_dropped": 3,
///     "dbs_dropped": 1
/// }
/// </code></example>
        public DbDrop (Arguments args, OptArgs optargs)
         : base(TermType.DB_DROP, args, optargs) {
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