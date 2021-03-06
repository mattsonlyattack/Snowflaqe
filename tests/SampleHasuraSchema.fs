module SampleHasuraSchema

open System
open Expecto
open Snowflaqe

let firstSchema = """
{
  "data": {
    "__schema": {
      "directives": [
        {
          "args": [
            {
              "name": "if",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Boolean",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "name": "include",
          "locations": ["FIELD", "FRAGMENT_SPREAD", "INLINE_FRAGMENT"],
          "description": null
        },
        {
          "args": [
            {
              "name": "if",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Boolean",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "name": "skip",
          "locations": ["FIELD", "FRAGMENT_SPREAD", "INLINE_FRAGMENT"],
          "description": null
        }
      ],
      "queryType": {
        "name": "query_root"
      },
      "subscriptionType": {
        "name": "subscription_root"
      },
      "types": [
        {
          "inputFields": null,
          "kind": "SCALAR",
          "possibleTypes": null,
          "interfaces": null,
          "name": "Boolean",
          "enumValues": null,
          "description": null,
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "SCALAR",
          "possibleTypes": null,
          "interfaces": null,
          "name": "Float",
          "enumValues": null,
          "description": null,
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_eq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_in",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Float",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "name": "_is_null",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Boolean",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_neq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_nin",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Float",
                    "ofType": null
                  }
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "Float_comparison_exp",
          "enumValues": null,
          "description": "expression to compare columns of type Float. All fields are combined with logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "SCALAR",
          "possibleTypes": null,
          "interfaces": null,
          "name": "ID",
          "enumValues": null,
          "description": null,
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "SCALAR",
          "possibleTypes": null,
          "interfaces": null,
          "name": "Int",
          "enumValues": null,
          "description": null,
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_eq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_in",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "name": "_is_null",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Boolean",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_neq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_nin",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  }
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "Int_comparison_exp",
          "enumValues": null,
          "description": "expression to compare columns of type Int. All fields are combined with logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "SCALAR",
          "possibleTypes": null,
          "interfaces": null,
          "name": "String",
          "enumValues": null,
          "description": null,
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_eq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_ilike",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_in",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "name": "_is_null",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Boolean",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_like",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_neq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_nilike",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_nin",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "String",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "name": "_nlike",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_nsimilar",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_similar",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "String_comparison_exp",
          "enumValues": null,
          "description": "expression to compare columns of type String. All fields are combined with logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "__Directive",
          "enumValues": null,
          "description": null,
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "args",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__InputValue",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "description",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "locations",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "ENUM",
                      "name": "__DirectiveLocation",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "__DirectiveLocation",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "ARGUMENT_DEFINITION",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "ENUM",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "ENUM_VALUE",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "FIELD",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "FIELD_DEFINITION",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "FRAGMENT_DEFINITION",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "FRAGMENT_SPREAD",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "INLINE_FRAGMENT",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "INPUT_FIELD_DEFINITION",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "INPUT_OBJECT",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "INTERFACE",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "MUTATION",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "OBJECT",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "QUERY",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "SCALAR",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "SCHEMA",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "SUBSCRIPTION",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "UNION",
              "description": null
            }
          ],
          "description": null,
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "__EnumValue",
          "enumValues": null,
          "description": null,
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "deprecationReason",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "description",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "isDeprecated",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Boolean",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "__Field",
          "enumValues": null,
          "description": null,
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "args",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__InputValue",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "deprecationReason",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "description",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "isDeprecated",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Boolean",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "type",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "__Type",
                  "ofType": null
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "__InputValue",
          "enumValues": null,
          "description": null,
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "defaultValue",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "description",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "type",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "__Type",
                  "ofType": null
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "__Schema",
          "enumValues": null,
          "description": null,
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "directives",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__Directive",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "mutationType",
              "type": {
                "kind": "OBJECT",
                "name": "__Type",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "queryType",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "__Type",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "subscriptionType",
              "type": {
                "kind": "OBJECT",
                "name": "__Type",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "types",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "__Type",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "__Type",
          "enumValues": null,
          "description": null,
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "description",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "includeDeprecated",
                  "defaultValue": "false",
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "enumValues",
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__EnumValue",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "includeDeprecated",
                  "defaultValue": "false",
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "fields",
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__Field",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "inputFields",
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__InputValue",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "interfaces",
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__Type",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "kind",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "ENUM",
                  "name": "__TypeKind",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "ofType",
              "type": {
                "kind": "OBJECT",
                "name": "__Type",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "possibleTypes",
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "OBJECT",
                    "name": "__Type",
                    "ofType": null
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "__TypeKind",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "ENUM",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "INPUT_OBJECT",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "INTERFACE",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "LIST",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "NON_NULL",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "OBJECT",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "SCALAR",
              "description": null
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "UNION",
              "description": null
            }
          ],
          "description": null,
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "mutation_root",
          "enumValues": null,
          "description": "mutation root",
          "fields": [
            {
              "args": [
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producerProducts_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be deleted"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_producerProducts",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_mutation_response",
                "ofType": null
              },
              "description": "delete data from the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_producerProducts_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts",
                "ofType": null
              },
              "description": "delete single row from the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producers_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be deleted"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_producers",
              "type": {
                "kind": "OBJECT",
                "name": "producers_mutation_response",
                "ofType": null
              },
              "description": "delete data from the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_producers_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producers",
                "ofType": null
              },
              "description": "delete single row from the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "products_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be deleted"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_products",
              "type": {
                "kind": "OBJECT",
                "name": "products_mutation_response",
                "ofType": null
              },
              "description": "delete data from the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_products_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "products",
                "ofType": null
              },
              "description": "delete single row from the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrderDetails_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be deleted"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_userOrderDetails",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_mutation_response",
                "ofType": null
              },
              "description": "delete data from the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_userOrderDetails_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails",
                "ofType": null
              },
              "description": "delete single row from the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrders_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be deleted"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_userOrders",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_mutation_response",
                "ofType": null
              },
              "description": "delete data from the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_userOrders_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders",
                "ofType": null
              },
              "description": "delete single row from the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "users_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be deleted"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_users",
              "type": {
                "kind": "OBJECT",
                "name": "users_mutation_response",
                "ofType": null
              },
              "description": "delete data from the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "delete_users_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "users",
                "ofType": null
              },
              "description": "delete single row from the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "objects",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "LIST",
                      "name": null,
                      "ofType": {
                        "kind": "NON_NULL",
                        "name": null,
                        "ofType": {
                          "kind": "INPUT_OBJECT",
                          "name": "producerProducts_insert_input",
                          "ofType": null
                        }
                      }
                    }
                  },
                  "description": "the rows to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_producerProducts",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_mutation_response",
                "ofType": null
              },
              "description": "insert data into the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "object",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producerProducts_insert_input",
                      "ofType": null
                    }
                  },
                  "description": "the row to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_producerProducts_one",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts",
                "ofType": null
              },
              "description": "insert a single row into the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "objects",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "LIST",
                      "name": null,
                      "ofType": {
                        "kind": "NON_NULL",
                        "name": null,
                        "ofType": {
                          "kind": "INPUT_OBJECT",
                          "name": "producers_insert_input",
                          "ofType": null
                        }
                      }
                    }
                  },
                  "description": "the rows to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_producers",
              "type": {
                "kind": "OBJECT",
                "name": "producers_mutation_response",
                "ofType": null
              },
              "description": "insert data into the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "object",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producers_insert_input",
                      "ofType": null
                    }
                  },
                  "description": "the row to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_producers_one",
              "type": {
                "kind": "OBJECT",
                "name": "producers",
                "ofType": null
              },
              "description": "insert a single row into the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "objects",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "LIST",
                      "name": null,
                      "ofType": {
                        "kind": "NON_NULL",
                        "name": null,
                        "ofType": {
                          "kind": "INPUT_OBJECT",
                          "name": "products_insert_input",
                          "ofType": null
                        }
                      }
                    }
                  },
                  "description": "the rows to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_products",
              "type": {
                "kind": "OBJECT",
                "name": "products_mutation_response",
                "ofType": null
              },
              "description": "insert data into the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "object",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "products_insert_input",
                      "ofType": null
                    }
                  },
                  "description": "the row to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_products_one",
              "type": {
                "kind": "OBJECT",
                "name": "products",
                "ofType": null
              },
              "description": "insert a single row into the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "objects",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "LIST",
                      "name": null,
                      "ofType": {
                        "kind": "NON_NULL",
                        "name": null,
                        "ofType": {
                          "kind": "INPUT_OBJECT",
                          "name": "userOrderDetails_insert_input",
                          "ofType": null
                        }
                      }
                    }
                  },
                  "description": "the rows to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_userOrderDetails",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_mutation_response",
                "ofType": null
              },
              "description": "insert data into the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "object",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrderDetails_insert_input",
                      "ofType": null
                    }
                  },
                  "description": "the row to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_userOrderDetails_one",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails",
                "ofType": null
              },
              "description": "insert a single row into the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "objects",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "LIST",
                      "name": null,
                      "ofType": {
                        "kind": "NON_NULL",
                        "name": null,
                        "ofType": {
                          "kind": "INPUT_OBJECT",
                          "name": "userOrders_insert_input",
                          "ofType": null
                        }
                      }
                    }
                  },
                  "description": "the rows to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_userOrders",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_mutation_response",
                "ofType": null
              },
              "description": "insert data into the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "object",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrders_insert_input",
                      "ofType": null
                    }
                  },
                  "description": "the row to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_userOrders_one",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders",
                "ofType": null
              },
              "description": "insert a single row into the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "objects",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "LIST",
                      "name": null,
                      "ofType": {
                        "kind": "NON_NULL",
                        "name": null,
                        "ofType": {
                          "kind": "INPUT_OBJECT",
                          "name": "users_insert_input",
                          "ofType": null
                        }
                      }
                    }
                  },
                  "description": "the rows to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_users",
              "type": {
                "kind": "OBJECT",
                "name": "users_mutation_response",
                "ofType": null
              },
              "description": "insert data into the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "object",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "users_insert_input",
                      "ofType": null
                    }
                  },
                  "description": "the row to be inserted"
                },
                {
                  "name": "on_conflict",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_on_conflict",
                    "ofType": null
                  },
                  "description": "on conflict condition"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "insert_users_one",
              "type": {
                "kind": "OBJECT",
                "name": "users",
                "ofType": null
              },
              "description": "insert a single row into the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producerProducts_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be updated"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_producerProducts",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_mutation_response",
                "ofType": null
              },
              "description": "update data of the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "pk_columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producerProducts_pk_columns_input",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_producerProducts_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts",
                "ofType": null
              },
              "description": "update single row of the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producers_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be updated"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_producers",
              "type": {
                "kind": "OBJECT",
                "name": "producers_mutation_response",
                "ofType": null
              },
              "description": "update data of the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "pk_columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producers_pk_columns_input",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_producers_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producers",
                "ofType": null
              },
              "description": "update single row of the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "products_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be updated"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_products",
              "type": {
                "kind": "OBJECT",
                "name": "products_mutation_response",
                "ofType": null
              },
              "description": "update data of the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "pk_columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "products_pk_columns_input",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_products_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "products",
                "ofType": null
              },
              "description": "update single row of the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrderDetails_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be updated"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_userOrderDetails",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_mutation_response",
                "ofType": null
              },
              "description": "update data of the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "pk_columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrderDetails_pk_columns_input",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_userOrderDetails_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails",
                "ofType": null
              },
              "description": "update single row of the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrders_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be updated"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_userOrders",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_mutation_response",
                "ofType": null
              },
              "description": "update data of the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "pk_columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrders_pk_columns_input",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_userOrders_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders",
                "ofType": null
              },
              "description": "update single row of the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "users_bool_exp",
                      "ofType": null
                    }
                  },
                  "description": "filter the rows which have to be updated"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_users",
              "type": {
                "kind": "OBJECT",
                "name": "users_mutation_response",
                "ofType": null
              },
              "description": "update data of the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "_inc",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_inc_input",
                    "ofType": null
                  },
                  "description": "increments the integer columns with given value of the filtered values"
                },
                {
                  "name": "_set",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_set_input",
                    "ofType": null
                  },
                  "description": "sets the columns of the filtered rows to the given values"
                },
                {
                  "name": "pk_columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "users_pk_columns_input",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "update_users_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "users",
                "ofType": null
              },
              "description": "update single row of the table: \"users\""
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "order_by",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "asc",
              "description": "in the ascending order, nulls last"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "asc_nulls_first",
              "description": "in the ascending order, nulls first"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "asc_nulls_last",
              "description": "in the ascending order, nulls last"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "desc",
              "description": "in the descending order, nulls first"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "desc_nulls_first",
              "description": "in the descending order, nulls first"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "desc_nulls_last",
              "description": "in the descending order, nulls last"
            }
          ],
          "description": "column ordering options",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts",
          "enumValues": null,
          "description": "columns and relationships of \"producerProducts\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producer",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producers",
                  "ofType": null
                }
              },
              "description": "An object relationship"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "product",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "products",
                  "ofType": null
                }
              },
              "description": "An object relationship"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrderDetails",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "An array relationship"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrderDetails_aggregate",
                  "ofType": null
                }
              },
              "description": "An aggregated array relationship"
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_aggregate",
          "enumValues": null,
          "description": "aggregated selection of \"producerProducts\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "aggregate",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_aggregate_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "nodes",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producerProducts",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_aggregate_fields",
          "enumValues": null,
          "description": "aggregate fields of \"producerProducts\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "avg",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_avg_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": null
                },
                {
                  "name": "distinct",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "count",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "max",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_max_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "min",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_min_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_stddev_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_pop",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_stddev_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_samp",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_stddev_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "sum",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_sum_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_pop",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_var_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_samp",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_var_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "variance",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts_variance_fields",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "avg",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_avg_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "count",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "max",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_max_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "min",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_min_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_stddev_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_stddev_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_stddev_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "sum",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_sum_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_var_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_var_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "variance",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_variance_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_aggregate_order_by",
          "enumValues": null,
          "description": "order by aggregate values of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producerProducts_insert_input",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_arr_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting array relation for remote table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_avg_fields",
          "enumValues": null,
          "description": "aggregate avg on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_avg_order_by",
          "enumValues": null,
          "description": "order by avg() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_and",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "producerProducts_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "_not",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_or",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "producerProducts_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producer",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "product",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderDetails",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_bool_exp",
          "enumValues": null,
          "description": "Boolean expression to filter rows from the table \"producerProducts\". All fields are combined with a logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_constraint",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_pkey",
              "description": "unique or primary key constraint"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_producerId_productId_key",
              "description": "unique or primary key constraint"
            }
          ],
          "description": "unique or primary key constraints on table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_inc_input",
          "enumValues": null,
          "description": "input type for incrementing integer column in table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producer",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_obj_rel_insert_input",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "product",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_obj_rel_insert_input",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderDetails",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_arr_rel_insert_input",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_insert_input",
          "enumValues": null,
          "description": "input type for inserting data into table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_max_fields",
          "enumValues": null,
          "description": "aggregate max on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_max_order_by",
          "enumValues": null,
          "description": "order by max() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_min_fields",
          "enumValues": null,
          "description": "aggregate min on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_min_order_by",
          "enumValues": null,
          "description": "order by min() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_mutation_response",
          "enumValues": null,
          "description": "response of any mutation on the table \"producerProducts\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "affected_rows",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": "number of affected rows by the mutation"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "returning",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producerProducts",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "data of the affected rows by the mutation"
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "producerProducts_insert_input",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_obj_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting object relation for remote table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "constraint",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "ENUM",
                  "name": "producerProducts_constraint",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "update_columns",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "ENUM",
                      "name": "producerProducts_update_column",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "where",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_on_conflict",
          "enumValues": null,
          "description": "on conflict condition type for table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producer",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "product",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderDetails_aggregate",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_aggregate_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_order_by",
          "enumValues": null,
          "description": "ordering options when selecting data from \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_pk_columns_input",
          "enumValues": null,
          "description": "primary key columns input for table: \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_select_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "description": "column name"
            }
          ],
          "description": "select columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_set_input",
          "enumValues": null,
          "description": "input type for updating data in table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_stddev_fields",
          "enumValues": null,
          "description": "aggregate stddev on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_stddev_order_by",
          "enumValues": null,
          "description": "order by stddev() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_stddev_pop_fields",
          "enumValues": null,
          "description": "aggregate stddev_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_stddev_pop_order_by",
          "enumValues": null,
          "description": "order by stddev_pop() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_stddev_samp_fields",
          "enumValues": null,
          "description": "aggregate stddev_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_stddev_samp_order_by",
          "enumValues": null,
          "description": "order by stddev_samp() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_sum_fields",
          "enumValues": null,
          "description": "aggregate sum on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_sum_order_by",
          "enumValues": null,
          "description": "order by sum() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_update_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "description": "column name"
            }
          ],
          "description": "update columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_var_pop_fields",
          "enumValues": null,
          "description": "aggregate var_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_var_pop_order_by",
          "enumValues": null,
          "description": "order by var_pop() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_var_samp_fields",
          "enumValues": null,
          "description": "aggregate var_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_var_samp_order_by",
          "enumValues": null,
          "description": "order by var_samp() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producerProducts_variance_fields",
          "enumValues": null,
          "description": "aggregate variance on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "productId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "productId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producerProducts_variance_order_by",
          "enumValues": null,
          "description": "order by variance() on columns of table \"producerProducts\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers",
          "enumValues": null,
          "description": "columns and relationships of \"producers\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "link",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producerProducts",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "An array relationship"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producerProducts_aggregate",
                  "ofType": null
                }
              },
              "description": "An aggregated array relationship"
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_aggregate",
          "enumValues": null,
          "description": "aggregated selection of \"producers\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "aggregate",
              "type": {
                "kind": "OBJECT",
                "name": "producers_aggregate_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "nodes",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producers",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_aggregate_fields",
          "enumValues": null,
          "description": "aggregate fields of \"producers\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "avg",
              "type": {
                "kind": "OBJECT",
                "name": "producers_avg_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producers_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": null
                },
                {
                  "name": "distinct",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "count",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "max",
              "type": {
                "kind": "OBJECT",
                "name": "producers_max_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "min",
              "type": {
                "kind": "OBJECT",
                "name": "producers_min_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev",
              "type": {
                "kind": "OBJECT",
                "name": "producers_stddev_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_pop",
              "type": {
                "kind": "OBJECT",
                "name": "producers_stddev_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_samp",
              "type": {
                "kind": "OBJECT",
                "name": "producers_stddev_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "sum",
              "type": {
                "kind": "OBJECT",
                "name": "producers_sum_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_pop",
              "type": {
                "kind": "OBJECT",
                "name": "producers_var_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_samp",
              "type": {
                "kind": "OBJECT",
                "name": "producers_var_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "variance",
              "type": {
                "kind": "OBJECT",
                "name": "producers_variance_fields",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "avg",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_avg_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "count",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "max",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_max_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "min",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_min_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_stddev_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_stddev_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_stddev_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "sum",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_sum_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_var_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_var_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "variance",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_variance_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_aggregate_order_by",
          "enumValues": null,
          "description": "order by aggregate values of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "producers_insert_input",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_arr_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting array relation for remote table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_avg_fields",
          "enumValues": null,
          "description": "aggregate avg on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_avg_order_by",
          "enumValues": null,
          "description": "order by avg() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_and",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "producers_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "_not",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_or",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "producers_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "link",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "String_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "String_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProducts",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_bool_exp",
          "enumValues": null,
          "description": "Boolean expression to filter rows from the table \"producers\". All fields are combined with a logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_constraint",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers_name_key",
              "description": "unique or primary key constraint"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers_pkey",
              "description": "unique or primary key constraint"
            }
          ],
          "description": "unique or primary key constraints on table \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_inc_input",
          "enumValues": null,
          "description": "input type for incrementing integer column in table \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "link",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProducts",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_arr_rel_insert_input",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_insert_input",
          "enumValues": null,
          "description": "input type for inserting data into table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_max_fields",
          "enumValues": null,
          "description": "aggregate max on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "link",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "link",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_max_order_by",
          "enumValues": null,
          "description": "order by max() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_min_fields",
          "enumValues": null,
          "description": "aggregate min on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "link",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "link",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_min_order_by",
          "enumValues": null,
          "description": "order by min() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_mutation_response",
          "enumValues": null,
          "description": "response of any mutation on the table \"producers\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "affected_rows",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": "number of affected rows by the mutation"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "returning",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producers",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "data of the affected rows by the mutation"
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "producers_insert_input",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_obj_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting object relation for remote table \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "constraint",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "ENUM",
                  "name": "producers_constraint",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "update_columns",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "ENUM",
                      "name": "producers_update_column",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "where",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producers_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_on_conflict",
          "enumValues": null,
          "description": "on conflict condition type for table \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "link",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProducts_aggregate",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_aggregate_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_order_by",
          "enumValues": null,
          "description": "ordering options when selecting data from \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_pk_columns_input",
          "enumValues": null,
          "description": "primary key columns input for table: \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_select_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "link",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "description": "column name"
            }
          ],
          "description": "select columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "link",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_set_input",
          "enumValues": null,
          "description": "input type for updating data in table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_stddev_fields",
          "enumValues": null,
          "description": "aggregate stddev on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_stddev_order_by",
          "enumValues": null,
          "description": "order by stddev() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_stddev_pop_fields",
          "enumValues": null,
          "description": "aggregate stddev_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_stddev_pop_order_by",
          "enumValues": null,
          "description": "order by stddev_pop() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_stddev_samp_fields",
          "enumValues": null,
          "description": "aggregate stddev_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_stddev_samp_order_by",
          "enumValues": null,
          "description": "order by stddev_samp() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_sum_fields",
          "enumValues": null,
          "description": "aggregate sum on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_sum_order_by",
          "enumValues": null,
          "description": "order by sum() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_update_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "link",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "description": "column name"
            }
          ],
          "description": "update columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_var_pop_fields",
          "enumValues": null,
          "description": "aggregate var_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_var_pop_order_by",
          "enumValues": null,
          "description": "order by var_pop() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_var_samp_fields",
          "enumValues": null,
          "description": "aggregate var_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_var_samp_order_by",
          "enumValues": null,
          "description": "order by var_samp() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "producers_variance_fields",
          "enumValues": null,
          "description": "aggregate variance on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "producers_variance_order_by",
          "enumValues": null,
          "description": "order by variance() on columns of table \"producers\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products",
          "enumValues": null,
          "description": "columns and relationships of \"products\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producerProducts",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "An array relationship"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producerProducts_aggregate",
                  "ofType": null
                }
              },
              "description": "An aggregated array relationship"
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_aggregate",
          "enumValues": null,
          "description": "aggregated selection of \"products\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "aggregate",
              "type": {
                "kind": "OBJECT",
                "name": "products_aggregate_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "nodes",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "products",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_aggregate_fields",
          "enumValues": null,
          "description": "aggregate fields of \"products\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "avg",
              "type": {
                "kind": "OBJECT",
                "name": "products_avg_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "products_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": null
                },
                {
                  "name": "distinct",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "count",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "max",
              "type": {
                "kind": "OBJECT",
                "name": "products_max_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "min",
              "type": {
                "kind": "OBJECT",
                "name": "products_min_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev",
              "type": {
                "kind": "OBJECT",
                "name": "products_stddev_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_pop",
              "type": {
                "kind": "OBJECT",
                "name": "products_stddev_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_samp",
              "type": {
                "kind": "OBJECT",
                "name": "products_stddev_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "sum",
              "type": {
                "kind": "OBJECT",
                "name": "products_sum_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_pop",
              "type": {
                "kind": "OBJECT",
                "name": "products_var_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_samp",
              "type": {
                "kind": "OBJECT",
                "name": "products_var_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "variance",
              "type": {
                "kind": "OBJECT",
                "name": "products_variance_fields",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "avg",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_avg_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "count",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "max",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_max_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "min",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_min_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_stddev_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_stddev_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_stddev_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "sum",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_sum_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_var_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_var_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "variance",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_variance_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_aggregate_order_by",
          "enumValues": null,
          "description": "order by aggregate values of table \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "products_insert_input",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_arr_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting array relation for remote table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_avg_fields",
          "enumValues": null,
          "description": "aggregate avg on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_avg_order_by",
          "enumValues": null,
          "description": "order by avg() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_and",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "products_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "_not",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_or",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "products_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "String_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProducts",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_bool_exp",
          "enumValues": null,
          "description": "Boolean expression to filter rows from the table \"products\". All fields are combined with a logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_constraint",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products_name_key",
              "description": "unique or primary key constraint"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products_pkey",
              "description": "unique or primary key constraint"
            }
          ],
          "description": "unique or primary key constraints on table \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_inc_input",
          "enumValues": null,
          "description": "input type for incrementing integer column in table \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProducts",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_arr_rel_insert_input",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_insert_input",
          "enumValues": null,
          "description": "input type for inserting data into table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_max_fields",
          "enumValues": null,
          "description": "aggregate max on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_max_order_by",
          "enumValues": null,
          "description": "order by max() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_min_fields",
          "enumValues": null,
          "description": "aggregate min on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_min_order_by",
          "enumValues": null,
          "description": "order by min() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_mutation_response",
          "enumValues": null,
          "description": "response of any mutation on the table \"products\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "affected_rows",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": "number of affected rows by the mutation"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "returning",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "products",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "data of the affected rows by the mutation"
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "products_insert_input",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_obj_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting object relation for remote table \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "constraint",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "ENUM",
                  "name": "products_constraint",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "update_columns",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "ENUM",
                      "name": "products_update_column",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "where",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "products_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_on_conflict",
          "enumValues": null,
          "description": "on conflict condition type for table \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProducts_aggregate",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_aggregate_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_order_by",
          "enumValues": null,
          "description": "ordering options when selecting data from \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_pk_columns_input",
          "enumValues": null,
          "description": "primary key columns input for table: \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_select_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "description": "column name"
            }
          ],
          "description": "select columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "name",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_set_input",
          "enumValues": null,
          "description": "input type for updating data in table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_stddev_fields",
          "enumValues": null,
          "description": "aggregate stddev on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_stddev_order_by",
          "enumValues": null,
          "description": "order by stddev() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_stddev_pop_fields",
          "enumValues": null,
          "description": "aggregate stddev_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_stddev_pop_order_by",
          "enumValues": null,
          "description": "order by stddev_pop() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_stddev_samp_fields",
          "enumValues": null,
          "description": "aggregate stddev_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_stddev_samp_order_by",
          "enumValues": null,
          "description": "order by stddev_samp() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_sum_fields",
          "enumValues": null,
          "description": "aggregate sum on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_sum_order_by",
          "enumValues": null,
          "description": "order by sum() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_update_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "name",
              "description": "column name"
            }
          ],
          "description": "update columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_var_pop_fields",
          "enumValues": null,
          "description": "aggregate var_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_var_pop_order_by",
          "enumValues": null,
          "description": "order by var_pop() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_var_samp_fields",
          "enumValues": null,
          "description": "aggregate var_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_var_samp_order_by",
          "enumValues": null,
          "description": "order by var_samp() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "products_variance_fields",
          "enumValues": null,
          "description": "aggregate variance on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "products_variance_order_by",
          "enumValues": null,
          "description": "order by variance() on columns of table \"products\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "query_root",
          "enumValues": null,
          "description": "query root",
          "fields": [
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producerProducts",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producerProducts_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts",
                "ofType": null
              },
              "description": "fetch data from the table: \"producerProducts\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producers_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producers_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producers",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producers_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producers_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producers_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producers",
                "ofType": null
              },
              "description": "fetch data from the table: \"producers\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "products_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "products_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "products",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "products_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "products_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "products_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "products",
                "ofType": null
              },
              "description": "fetch data from the table: \"products\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrderDetails",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrderDetails_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails",
                "ofType": null
              },
              "description": "fetch data from the table: \"userOrderDetails\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrders_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrders_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrders",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrders_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrders_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrders_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders",
                "ofType": null
              },
              "description": "fetch data from the table: \"userOrders\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "users_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "users_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "users",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "users_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "users_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "users_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "users",
                "ofType": null
              },
              "description": "fetch data from the table: \"users\" using primary key columns"
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "subscription_root",
          "enumValues": null,
          "description": "subscription root",
          "fields": [
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producerProducts",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producerProducts_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producerProducts_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producerProducts_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producerProducts_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"producerProducts\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProducts_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producerProducts",
                "ofType": null
              },
              "description": "fetch data from the table: \"producerProducts\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producers_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producers_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "producers",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "producers_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "producers_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "producers_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producers_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"producers\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producers_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "producers",
                "ofType": null
              },
              "description": "fetch data from the table: \"producers\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "products_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "products_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "products",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "products_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "products_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "products_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "products_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"products\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "products_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "products",
                "ofType": null
              },
              "description": "fetch data from the table: \"products\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrderDetails",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrderDetails_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"userOrderDetails\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails",
                "ofType": null
              },
              "description": "fetch data from the table: \"userOrderDetails\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrders_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrders_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrders",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrders_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrders_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrders_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"userOrders\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders",
                "ofType": null
              },
              "description": "fetch data from the table: \"userOrders\" using primary key columns"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "users_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "users_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "users",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "fetch data from the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "users_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "users_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "users_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "users_aggregate",
                  "ofType": null
                }
              },
              "description": "fetch aggregated fields from the table: \"users\""
            },
            {
              "args": [
                {
                  "name": "id",
                  "defaultValue": null,
                  "type": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "SCALAR",
                      "name": "Int",
                      "ofType": null
                    }
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users_by_pk",
              "type": {
                "kind": "OBJECT",
                "name": "users",
                "ofType": null
              },
              "description": "fetch data from the table: \"users\" using primary key columns"
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "SCALAR",
          "possibleTypes": null,
          "interfaces": null,
          "name": "timestamptz",
          "enumValues": null,
          "description": null,
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "SCALAR",
          "possibleTypes": null,
          "interfaces": null,
          "name": "myCustomType",
          "enumValues": null,
          "description": null,
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_eq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_gte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_in",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "timestamptz",
                    "ofType": null
                  }
                }
              },
              "description": null
            },
            {
              "name": "_is_null",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Boolean",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lt",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_lte",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_neq",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_nin",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "NON_NULL",
                  "name": null,
                  "ofType": {
                    "kind": "SCALAR",
                    "name": "timestamptz",
                    "ofType": null
                  }
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "timestamptz_comparison_exp",
          "enumValues": null,
          "description": "expression to compare columns of type timestamptz. All fields are combined with logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails",
          "enumValues": null,
          "description": "columns and relationships of \"userOrderDetails\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "amount",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Float",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProduct",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "producerProducts",
                  "ofType": null
                }
              },
              "description": "An object relationship"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrder",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrders",
                  "ofType": null
                }
              },
              "description": "An object relationship"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_aggregate",
          "enumValues": null,
          "description": "aggregated selection of \"userOrderDetails\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "aggregate",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_aggregate_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "nodes",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrderDetails",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_aggregate_fields",
          "enumValues": null,
          "description": "aggregate fields of \"userOrderDetails\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "avg",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_avg_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": null
                },
                {
                  "name": "distinct",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "count",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "max",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_max_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "min",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_min_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_stddev_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_pop",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_stddev_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_samp",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_stddev_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "sum",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_sum_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_pop",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_var_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_samp",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_var_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "variance",
              "type": {
                "kind": "OBJECT",
                "name": "userOrderDetails_variance_fields",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "avg",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_avg_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "count",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "max",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_max_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "min",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_min_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_stddev_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_stddev_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_stddev_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "sum",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_sum_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_var_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_var_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "variance",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_variance_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_aggregate_order_by",
          "enumValues": null,
          "description": "order by aggregate values of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrderDetails_insert_input",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_arr_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting array relation for remote table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_avg_fields",
          "enumValues": null,
          "description": "aggregate avg on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_avg_order_by",
          "enumValues": null,
          "description": "order by avg() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_and",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "userOrderDetails_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "_not",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_or",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "userOrderDetails_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "amount",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "String_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Float_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProduct",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "String_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrder",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_bool_exp",
          "enumValues": null,
          "description": "Boolean expression to filter rows from the table \"userOrderDetails\". All fields are combined with a logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_constraint",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_pkey",
              "description": "unique or primary key constraint"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_userOrderId_producerProductId_key",
              "description": "unique or primary key constraint"
            }
          ],
          "description": "unique or primary key constraints on table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_inc_input",
          "enumValues": null,
          "description": "input type for incrementing integer column in table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "amount",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProduct",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_obj_rel_insert_input",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrder",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_obj_rel_insert_input",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_insert_input",
          "enumValues": null,
          "description": "input type for inserting data into table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_max_fields",
          "enumValues": null,
          "description": "aggregate max on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "amount",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "amount",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_max_order_by",
          "enumValues": null,
          "description": "order by max() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_min_fields",
          "enumValues": null,
          "description": "aggregate min on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "amount",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "amount",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_min_order_by",
          "enumValues": null,
          "description": "order by min() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_mutation_response",
          "enumValues": null,
          "description": "response of any mutation on the table \"userOrderDetails\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "affected_rows",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": "number of affected rows by the mutation"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "returning",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrderDetails",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "data of the affected rows by the mutation"
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "userOrderDetails_insert_input",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_obj_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting object relation for remote table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "constraint",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "ENUM",
                  "name": "userOrderDetails_constraint",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "update_columns",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "ENUM",
                      "name": "userOrderDetails_update_column",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "where",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_on_conflict",
          "enumValues": null,
          "description": "on conflict condition type for table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "amount",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProduct",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "producerProducts_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrder",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_order_by",
          "enumValues": null,
          "description": "ordering options when selecting data from \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_pk_columns_input",
          "enumValues": null,
          "description": "primary key columns input for table: \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_select_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "amount",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "description": "column name"
            }
          ],
          "description": "select columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "amount",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_set_input",
          "enumValues": null,
          "description": "input type for updating data in table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_stddev_fields",
          "enumValues": null,
          "description": "aggregate stddev on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_stddev_order_by",
          "enumValues": null,
          "description": "order by stddev() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_stddev_pop_fields",
          "enumValues": null,
          "description": "aggregate stddev_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_stddev_pop_order_by",
          "enumValues": null,
          "description": "order by stddev_pop() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_stddev_samp_fields",
          "enumValues": null,
          "description": "aggregate stddev_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_stddev_samp_order_by",
          "enumValues": null,
          "description": "order by stddev_samp() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_sum_fields",
          "enumValues": null,
          "description": "aggregate sum on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_sum_order_by",
          "enumValues": null,
          "description": "order by sum() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_update_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "amount",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "description": "column name"
            }
          ],
          "description": "update columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_var_pop_fields",
          "enumValues": null,
          "description": "aggregate var_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_var_pop_order_by",
          "enumValues": null,
          "description": "order by var_pop() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_var_samp_fields",
          "enumValues": null,
          "description": "aggregate var_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_var_samp_order_by",
          "enumValues": null,
          "description": "order by var_samp() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrderDetails_variance_fields",
          "enumValues": null,
          "description": "aggregate variance on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "price",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "producerProductId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "price",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "producerProductId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrderDetails_variance_order_by",
          "enumValues": null,
          "description": "order by variance() on columns of table \"userOrderDetails\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders",
          "enumValues": null,
          "description": "columns and relationships of \"userOrders\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "deliveryDate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "timestamptz",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "user",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "users",
                  "ofType": null
                }
              },
              "description": "An object relationship"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrderDetails",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "An array relationship"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrderDetails_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrderDetails_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrderDetails_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrderDetails_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrderDetails_aggregate",
                  "ofType": null
                }
              },
              "description": "An aggregated array relationship"
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_aggregate",
          "enumValues": null,
          "description": "aggregated selection of \"userOrders\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "aggregate",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_aggregate_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "nodes",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrders",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_aggregate_fields",
          "enumValues": null,
          "description": "aggregate fields of \"userOrders\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "avg",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_avg_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrders_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": null
                },
                {
                  "name": "distinct",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "count",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "max",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_max_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "min",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_min_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_stddev_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_pop",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_stddev_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_samp",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_stddev_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "sum",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_sum_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_pop",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_var_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_samp",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_var_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "variance",
              "type": {
                "kind": "OBJECT",
                "name": "userOrders_variance_fields",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "avg",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_avg_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "count",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "max",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_max_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "min",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_min_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_stddev_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_stddev_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_stddev_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "sum",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_sum_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_var_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_var_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "variance",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_variance_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_aggregate_order_by",
          "enumValues": null,
          "description": "order by aggregate values of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "userOrders_insert_input",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_arr_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting array relation for remote table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_avg_fields",
          "enumValues": null,
          "description": "aggregate avg on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_avg_order_by",
          "enumValues": null,
          "description": "order by avg() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_and",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "userOrders_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "_not",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_or",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "userOrders_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "deliveryDate",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "timestamptz_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "String_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "user",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderDetails",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_bool_exp",
          "enumValues": null,
          "description": "Boolean expression to filter rows from the table \"userOrders\". All fields are combined with a logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_constraint",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders_pkey",
              "description": "unique or primary key constraint"
            }
          ],
          "description": "unique or primary key constraints on table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_inc_input",
          "enumValues": null,
          "description": "input type for incrementing integer column in table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "deliveryDate",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "user",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_obj_rel_insert_input",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderDetails",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_arr_rel_insert_input",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_insert_input",
          "enumValues": null,
          "description": "input type for inserting data into table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_max_fields",
          "enumValues": null,
          "description": "aggregate max on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "deliveryDate",
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "deliveryDate",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_max_order_by",
          "enumValues": null,
          "description": "order by max() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_min_fields",
          "enumValues": null,
          "description": "aggregate min on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "deliveryDate",
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "deliveryDate",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_min_order_by",
          "enumValues": null,
          "description": "order by min() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_mutation_response",
          "enumValues": null,
          "description": "response of any mutation on the table \"userOrders\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "affected_rows",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": "number of affected rows by the mutation"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "returning",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrders",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "data of the affected rows by the mutation"
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "userOrders_insert_input",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_obj_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting object relation for remote table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "constraint",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "ENUM",
                  "name": "userOrders_constraint",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "update_columns",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "ENUM",
                      "name": "userOrders_update_column",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "where",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_on_conflict",
          "enumValues": null,
          "description": "on conflict condition type for table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "deliveryDate",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "user",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrderDetails_aggregate",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrderDetails_aggregate_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_order_by",
          "enumValues": null,
          "description": "ordering options when selecting data from \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_pk_columns_input",
          "enumValues": null,
          "description": "primary key columns input for table: \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_select_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "deliveryDate",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "description": "column name"
            }
          ],
          "description": "select columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "deliveryDate",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "timestamptz",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "status",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_set_input",
          "enumValues": null,
          "description": "input type for updating data in table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_stddev_fields",
          "enumValues": null,
          "description": "aggregate stddev on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_stddev_order_by",
          "enumValues": null,
          "description": "order by stddev() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_stddev_pop_fields",
          "enumValues": null,
          "description": "aggregate stddev_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_stddev_pop_order_by",
          "enumValues": null,
          "description": "order by stddev_pop() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_stddev_samp_fields",
          "enumValues": null,
          "description": "aggregate stddev_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_stddev_samp_order_by",
          "enumValues": null,
          "description": "order by stddev_samp() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_sum_fields",
          "enumValues": null,
          "description": "aggregate sum on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_sum_order_by",
          "enumValues": null,
          "description": "order by sum() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_update_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "deliveryDate",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "status",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "description": "column name"
            }
          ],
          "description": "update columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_var_pop_fields",
          "enumValues": null,
          "description": "aggregate var_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_var_pop_order_by",
          "enumValues": null,
          "description": "order by var_pop() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_var_samp_fields",
          "enumValues": null,
          "description": "aggregate var_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_var_samp_order_by",
          "enumValues": null,
          "description": "order by var_samp() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "userOrders_variance_fields",
          "enumValues": null,
          "description": "aggregate variance on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userId",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userId",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "userOrders_variance_order_by",
          "enumValues": null,
          "description": "order by variance() on columns of table \"userOrders\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users",
          "enumValues": null,
          "description": "columns and relationships of \"users\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userName",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "String",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrders_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrders_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "userOrders",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "An array relationship"
            },
            {
              "args": [
                {
                  "name": "distinct_on",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "userOrders_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": "distinct select on columns"
                },
                {
                  "name": "limit",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "limit the number of rows returned"
                },
                {
                  "name": "offset",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Int",
                    "ofType": null
                  },
                  "description": "skip the first n rows. Use only with order_by"
                },
                {
                  "name": "order_by",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "INPUT_OBJECT",
                        "name": "userOrders_order_by",
                        "ofType": null
                      }
                    }
                  },
                  "description": "sort the rows by one or more columns"
                },
                {
                  "name": "where",
                  "defaultValue": null,
                  "type": {
                    "kind": "INPUT_OBJECT",
                    "name": "userOrders_bool_exp",
                    "ofType": null
                  },
                  "description": "filter the rows returned"
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userOrders_aggregate",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "OBJECT",
                  "name": "userOrders_aggregate",
                  "ofType": null
                }
              },
              "description": "An aggregated array relationship"
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_aggregate",
          "enumValues": null,
          "description": "aggregated selection of \"users\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "aggregate",
              "type": {
                "kind": "OBJECT",
                "name": "users_aggregate_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "nodes",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "users",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_aggregate_fields",
          "enumValues": null,
          "description": "aggregate fields of \"users\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "avg",
              "type": {
                "kind": "OBJECT",
                "name": "users_avg_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [
                {
                  "name": "columns",
                  "defaultValue": null,
                  "type": {
                    "kind": "LIST",
                    "name": null,
                    "ofType": {
                      "kind": "NON_NULL",
                      "name": null,
                      "ofType": {
                        "kind": "ENUM",
                        "name": "users_select_column",
                        "ofType": null
                      }
                    }
                  },
                  "description": null
                },
                {
                  "name": "distinct",
                  "defaultValue": null,
                  "type": {
                    "kind": "SCALAR",
                    "name": "Boolean",
                    "ofType": null
                  },
                  "description": null
                }
              ],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "count",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "max",
              "type": {
                "kind": "OBJECT",
                "name": "users_max_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "min",
              "type": {
                "kind": "OBJECT",
                "name": "users_min_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev",
              "type": {
                "kind": "OBJECT",
                "name": "users_stddev_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_pop",
              "type": {
                "kind": "OBJECT",
                "name": "users_stddev_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "stddev_samp",
              "type": {
                "kind": "OBJECT",
                "name": "users_stddev_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "sum",
              "type": {
                "kind": "OBJECT",
                "name": "users_sum_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_pop",
              "type": {
                "kind": "OBJECT",
                "name": "users_var_pop_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "var_samp",
              "type": {
                "kind": "OBJECT",
                "name": "users_var_samp_fields",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "variance",
              "type": {
                "kind": "OBJECT",
                "name": "users_variance_fields",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "avg",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_avg_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "count",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "max",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_max_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "min",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_min_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_stddev_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_stddev_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "stddev_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_stddev_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "sum",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_sum_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_pop",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_var_pop_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "var_samp",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_var_samp_order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "variance",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_variance_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_aggregate_order_by",
          "enumValues": null,
          "description": "order by aggregate values of table \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "INPUT_OBJECT",
                      "name": "users_insert_input",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_arr_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting array relation for remote table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_avg_fields",
          "enumValues": null,
          "description": "aggregate avg on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_avg_order_by",
          "enumValues": null,
          "description": "order by avg() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "_and",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "users_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "_not",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_bool_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "_or",
              "defaultValue": null,
              "type": {
                "kind": "LIST",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "users_bool_exp",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "Int_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userName",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "String_comparison_exp",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrders",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_bool_exp",
          "enumValues": null,
          "description": "Boolean expression to filter rows from the table \"users\". All fields are combined with a logical 'AND'.",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_constraint",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users_pkey",
              "description": "unique or primary key constraint"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "users_userName_key",
              "description": "unique or primary key constraint"
            }
          ],
          "description": "unique or primary key constraints on table \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_inc_input",
          "enumValues": null,
          "description": "input type for incrementing integer column in table \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userName",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrders",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_arr_rel_insert_input",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_insert_input",
          "enumValues": null,
          "description": "input type for inserting data into table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_max_fields",
          "enumValues": null,
          "description": "aggregate max on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userName",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userName",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_max_order_by",
          "enumValues": null,
          "description": "order by max() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_min_fields",
          "enumValues": null,
          "description": "aggregate min on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userName",
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userName",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_min_order_by",
          "enumValues": null,
          "description": "order by min() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_mutation_response",
          "enumValues": null,
          "description": "response of any mutation on the table \"users\"",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "affected_rows",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": "number of affected rows by the mutation"
            },
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "returning",
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "OBJECT",
                      "name": "users",
                      "ofType": null
                    }
                  }
                }
              },
              "description": "data of the affected rows by the mutation"
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "data",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "INPUT_OBJECT",
                  "name": "users_insert_input",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "on_conflict",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_on_conflict",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_obj_rel_insert_input",
          "enumValues": null,
          "description": "input type for inserting object relation for remote table \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "constraint",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "ENUM",
                  "name": "users_constraint",
                  "ofType": null
                }
              },
              "description": null
            },
            {
              "name": "update_columns",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "LIST",
                  "name": null,
                  "ofType": {
                    "kind": "NON_NULL",
                    "name": null,
                    "ofType": {
                      "kind": "ENUM",
                      "name": "users_update_column",
                      "ofType": null
                    }
                  }
                }
              },
              "description": null
            },
            {
              "name": "where",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "users_bool_exp",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_on_conflict",
          "enumValues": null,
          "description": "on conflict condition type for table \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userName",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userOrders_aggregate",
              "defaultValue": null,
              "type": {
                "kind": "INPUT_OBJECT",
                "name": "userOrders_aggregate_order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_order_by",
          "enumValues": null,
          "description": "ordering options when selecting data from \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "NON_NULL",
                "name": null,
                "ofType": {
                  "kind": "SCALAR",
                  "name": "Int",
                  "ofType": null
                }
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_pk_columns_input",
          "enumValues": null,
          "description": "primary key columns input for table: \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_select_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userName",
              "description": "column name"
            }
          ],
          "description": "select columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            },
            {
              "name": "userName",
              "defaultValue": null,
              "type": {
                "kind": "SCALAR",
                "name": "String",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_set_input",
          "enumValues": null,
          "description": "input type for updating data in table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_stddev_fields",
          "enumValues": null,
          "description": "aggregate stddev on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_stddev_order_by",
          "enumValues": null,
          "description": "order by stddev() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_stddev_pop_fields",
          "enumValues": null,
          "description": "aggregate stddev_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_stddev_pop_order_by",
          "enumValues": null,
          "description": "order by stddev_pop() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_stddev_samp_fields",
          "enumValues": null,
          "description": "aggregate stddev_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_stddev_samp_order_by",
          "enumValues": null,
          "description": "order by stddev_samp() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_sum_fields",
          "enumValues": null,
          "description": "aggregate sum on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Int",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_sum_order_by",
          "enumValues": null,
          "description": "order by sum() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "ENUM",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_update_column",
          "enumValues": [
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "description": "column name"
            },
            {
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "userName",
              "description": "column name"
            }
          ],
          "description": "update columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_var_pop_fields",
          "enumValues": null,
          "description": "aggregate var_pop on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_var_pop_order_by",
          "enumValues": null,
          "description": "order by var_pop() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_var_samp_fields",
          "enumValues": null,
          "description": "aggregate var_samp on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_var_samp_order_by",
          "enumValues": null,
          "description": "order by var_samp() on columns of table \"users\"",
          "fields": null
        },
        {
          "inputFields": null,
          "kind": "OBJECT",
          "possibleTypes": null,
          "interfaces": [],
          "name": "users_variance_fields",
          "enumValues": null,
          "description": "aggregate variance on columns",
          "fields": [
            {
              "args": [],
              "isDeprecated": false,
              "deprecationReason": null,
              "name": "id",
              "type": {
                "kind": "SCALAR",
                "name": "Float",
                "ofType": null
              },
              "description": null
            }
          ]
        },
        {
          "inputFields": [
            {
              "name": "id",
              "defaultValue": null,
              "type": {
                "kind": "ENUM",
                "name": "order_by",
                "ofType": null
              },
              "description": null
            }
          ],
          "kind": "INPUT_OBJECT",
          "possibleTypes": null,
          "interfaces": null,
          "name": "users_variance_order_by",
          "enumValues": null,
          "description": "order by variance() on columns of table \"users\"",
          "fields": null
        }
      ],
      "mutationType": {
        "name": "mutation_root"
      }
    }
  }
}
"""

let query = """
query GetCurrentOrderQuery($userId: Int!, $deliveryDate: timestamptz!) {
  userOrders(
    where: { userId: { _eq: $userId }, deliveryDate: { _gte: $deliveryDate } }
  ) {
    status
    id
    deliveryDate
    userOrderDetails {
      amount
      id
      price
      status
    }
  }
}
"""

let queryWithOptionalTimestamptz = """
query GetCurrentOrderQuery($userId: Int!, $deliveryDate: timestamptz) {
  userOrders(
    where: { userId: { _eq: $userId }, deliveryDate: { _gte: $deliveryDate } }
  ) {
    status
    id
    deliveryDate
    userOrderDetails {
      amount
      id
      price
      status
    }
  }
}
"""

let queryWithCustomType = """
query GetCurrentOrderQuery($userId: Int!, $deliveryDate: myCustomType!) {
  userOrders(
    where: { userId: { _eq: $userId }, deliveryDate: { _gte: $deliveryDate } }
  ) {
    status
    id
    deliveryDate
    userOrderDetails {
      amount
      id
      price
      status
    }
  }
}
"""
let hasuraTests = testList "Hasura" [
    test "Timestamptz is converted to DateTimeOffset" {
        let parsedSchema = Schema.parse firstSchema
        match parsedSchema with
        | Error error -> failwithf "Failed to parse the hasura schema:\n%s" error
        | Ok schema ->
            let parsedQuery = Query.parse query
            match parsedQuery with
            | Error error -> failwithf "Failed to parse query: %s" error
            | Ok query ->
                let name =
                    Query.findOperationName query
                    |> Option.defaultValue "DefaultQueryName"
                    |> CodeGen.normalizeName

                let generated =
                    let queryTypes = CodeGen.generateTypes "Root" "ErrorType" query schema
                    let ns = CodeGen.createQualifiedModule [ "Test"; name ] queryTypes
                    let file = CodeGen.createFile "Types.fs" [ ns ]
                    CodeGen.formatAst file

                let expected = """
[<RequireQualifiedAccess>]
module rec Test.GetCurrentOrderQuery

type InputVariables =
    { userId: int
      deliveryDate: System.DateTimeOffset }

/// An array relationship
type userOrderDetails =
    { amount: string
      id: int
      price: float
      status: string }

/// fetch data from the table: "userOrders"
type userOrders =
    { status: string
      id: int
      deliveryDate: System.DateTimeOffset
      /// An array relationship
      userOrderDetails: list<userOrderDetails> }

/// query root
type Root =
    { /// fetch data from the table: "userOrders"
      userOrders: list<userOrders> }

"""
                Expect.equal (Utilities.trimContentEnd generated) (Utilities.trimContentEnd expected) "The generated code correct"
    }

    test "Optional timestamptz is converted to Option<DateTimeOffset>" {
        let parsedSchema = Schema.parse firstSchema
        match parsedSchema with
        | Error error -> failwithf "Failed to parse the hasura schema:\n%s" error
        | Ok schema ->
            let parsedQuery = Query.parse queryWithOptionalTimestamptz
            match parsedQuery with
            | Error error -> failwithf "Failed to parse query: %s" error
            | Ok query ->
                let name =
                    Query.findOperationName query
                    |> Option.defaultValue "DefaultQueryName"
                    |> CodeGen.normalizeName

                let generated =
                    let queryTypes = CodeGen.generateTypes "Root" "ErrorType" query schema
                    let ns = CodeGen.createQualifiedModule [ "Test"; name ] queryTypes
                    let file = CodeGen.createFile "Types.fs" [ ns ]
                    CodeGen.formatAst file

                let expected = """
[<RequireQualifiedAccess>]
module rec Test.GetCurrentOrderQuery

type InputVariables =
    { userId: int
      deliveryDate: Option<System.DateTimeOffset> }

/// An array relationship
type userOrderDetails =
    { amount: string
      id: int
      price: float
      status: string }

/// fetch data from the table: "userOrders"
type userOrders =
    { status: string
      id: int
      deliveryDate: System.DateTimeOffset
      /// An array relationship
      userOrderDetails: list<userOrderDetails> }

/// query root
type Root =
    { /// fetch data from the table: "userOrders"
      userOrders: list<userOrders> }

"""
                Expect.equal (Utilities.trimContentEnd generated) (Utilities.trimContentEnd expected) "The generated code correct"
    }

    test "Custom types map to strings in query variables" {
        let parsedSchema = Schema.parse firstSchema
        match parsedSchema with
        | Error error -> failwithf "Failed to parse the hasura schema:\n%s" error
        | Ok schema ->
            let parsedQuery = Query.parse queryWithCustomType
            match parsedQuery with
            | Error error -> failwithf "Failed to parse query: %s" error
            | Ok query ->
                let name =
                    Query.findOperationName query
                    |> Option.defaultValue "DefaultQueryName"
                    |> CodeGen.normalizeName

                let generated =
                    let queryTypes = CodeGen.generateTypes "Root" "ErrorType" query schema
                    let ns = CodeGen.createQualifiedModule [ "Test"; name ] queryTypes
                    let file = CodeGen.createFile "Types.fs" [ ns ]
                    CodeGen.formatAst file

                let expected = """
[<RequireQualifiedAccess>]
module rec Test.GetCurrentOrderQuery

type InputVariables = { userId: int; deliveryDate: string }

/// An array relationship
type userOrderDetails =
    { amount: string
      id: int
      price: float
      status: string }

/// fetch data from the table: "userOrders"
type userOrders =
    { status: string
      id: int
      deliveryDate: System.DateTimeOffset
      /// An array relationship
      userOrderDetails: list<userOrderDetails> }

/// query root
type Root =
    { /// fetch data from the table: "userOrders"
      userOrders: list<userOrders> }

"""
                Expect.equal (Utilities.trimContentEnd generated) (Utilities.trimContentEnd expected) "The generated code correct"
    }
]