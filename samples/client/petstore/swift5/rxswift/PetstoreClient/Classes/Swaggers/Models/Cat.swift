//
// Cat.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct Cat: Codable {

    public var className: String
    public var color: String?
    public var declawed: Bool?

    public init(className: String, color: String?, declawed: Bool?) {
        self.className = className
        self.color = color
        self.declawed = declawed
    }


}

