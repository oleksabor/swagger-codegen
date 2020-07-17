# Swagger Petstore
#
# This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.
#
# OpenAPI spec version: 1.0.0
# Contact: apiteam@swagger.io
# Generated by: https://github.com/swagger-api/swagger-codegen.git


#' User Class
#'
#' @field id 
#' @field username 
#' @field firstName 
#' @field lastName 
#' @field email 
#' @field password 
#' @field phone 
#' @field userStatus 
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
User <- R6::R6Class(
  'User',
  public = list(
    `id` = NULL,
    `username` = NULL,
    `firstName` = NULL,
    `lastName` = NULL,
    `email` = NULL,
    `password` = NULL,
    `phone` = NULL,
    `userStatus` = NULL,
    initialize = function(`id`, `username`, `firstName`, `lastName`, `email`, `password`, `phone`, `userStatus`){
      if (!missing(`id`)) {
        stopifnot(is.numeric(`id`), length(`id`) == 1)
        self$`id` <- `id`
      }
      if (!missing(`username`)) {
        stopifnot(is.character(`username`), length(`username`) == 1)
        self$`username` <- `username`
      }
      if (!missing(`firstName`)) {
        stopifnot(is.character(`firstName`), length(`firstName`) == 1)
        self$`firstName` <- `firstName`
      }
      if (!missing(`lastName`)) {
        stopifnot(is.character(`lastName`), length(`lastName`) == 1)
        self$`lastName` <- `lastName`
      }
      if (!missing(`email`)) {
        stopifnot(is.character(`email`), length(`email`) == 1)
        self$`email` <- `email`
      }
      if (!missing(`password`)) {
        stopifnot(is.character(`password`), length(`password`) == 1)
        self$`password` <- `password`
      }
      if (!missing(`phone`)) {
        stopifnot(is.character(`phone`), length(`phone`) == 1)
        self$`phone` <- `phone`
      }
      if (!missing(`userStatus`)) {
        stopifnot(is.numeric(`userStatus`), length(`userStatus`) == 1)
        self$`userStatus` <- `userStatus`
      }
    },
    toJSON = function() {
      UserObject <- list()
      if (!is.null(self$`id`)) {
        UserObject[['id']] <- self$`id`
      }
      if (!is.null(self$`username`)) {
        UserObject[['username']] <- self$`username`
      }
      if (!is.null(self$`firstName`)) {
        UserObject[['firstName']] <- self$`firstName`
      }
      if (!is.null(self$`lastName`)) {
        UserObject[['lastName']] <- self$`lastName`
      }
      if (!is.null(self$`email`)) {
        UserObject[['email']] <- self$`email`
      }
      if (!is.null(self$`password`)) {
        UserObject[['password']] <- self$`password`
      }
      if (!is.null(self$`phone`)) {
        UserObject[['phone']] <- self$`phone`
      }
      if (!is.null(self$`userStatus`)) {
        UserObject[['userStatus']] <- self$`userStatus`
      }

      UserObject
    },
    fromJSON = function(UserJson) {
      UserObject <- jsonlite::fromJSON(UserJson)
      if (!is.null(UserObject$`id`)) {
        self$`id` <- UserObject$`id`
      }
      if (!is.null(UserObject$`username`)) {
        self$`username` <- UserObject$`username`
      }
      if (!is.null(UserObject$`firstName`)) {
        self$`firstName` <- UserObject$`firstName`
      }
      if (!is.null(UserObject$`lastName`)) {
        self$`lastName` <- UserObject$`lastName`
      }
      if (!is.null(UserObject$`email`)) {
        self$`email` <- UserObject$`email`
      }
      if (!is.null(UserObject$`password`)) {
        self$`password` <- UserObject$`password`
      }
      if (!is.null(UserObject$`phone`)) {
        self$`phone` <- UserObject$`phone`
      }
      if (!is.null(UserObject$`userStatus`)) {
        self$`userStatus` <- UserObject$`userStatus`
      }
    },
    toJSONString = function() {
       sprintf(
        '{
           "id": %d,
           "username": %s,
           "firstName": %s,
           "lastName": %s,
           "email": %s,
           "password": %s,
           "phone": %s,
           "userStatus": %d
        }',
        self$`id`,
        self$`username`,
        self$`firstName`,
        self$`lastName`,
        self$`email`,
        self$`password`,
        self$`phone`,
        self$`userStatus`
      )
    },
    fromJSONString = function(UserJson) {
      UserObject <- jsonlite::fromJSON(UserJson)
      self$`id` <- UserObject$`id`
      self$`username` <- UserObject$`username`
      self$`firstName` <- UserObject$`firstName`
      self$`lastName` <- UserObject$`lastName`
      self$`email` <- UserObject$`email`
      self$`password` <- UserObject$`password`
      self$`phone` <- UserObject$`phone`
      self$`userStatus` <- UserObject$`userStatus`
    }
  )
)
