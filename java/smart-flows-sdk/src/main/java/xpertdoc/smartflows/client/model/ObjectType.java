/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

import java.io.IOException;

/**
 * Gets or Sets objectType
 */
@JsonAdapter(ObjectType.Adapter.class)
public enum ObjectType {
  
  ASSET("asset"),
  
  CONNECTOR("connector"),
  
  DATASOURCE("datasource"),
  
  DATA("data"),
  
  DATASET("dataset"),
  
  DOCUMENT("document"),
  
  ENTITYREFERENCE("entityReference"),
  
  FLOW("flow"),
  
  LANGUAGE("language"),
  
  PRINTER("printer"),
  
  TAG("tag"),
  
  TAGGROUP("tagGroup"),
  
  TEMPLATE("template"),
  
  USER("user");

  private String value;

  ObjectType(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static ObjectType fromValue(String text) {
    for (ObjectType b : ObjectType.values()) {
      if (String.valueOf(b.value).equals(text)) {
        return b;
      }
    }
    return null;
  }

  public static class Adapter extends TypeAdapter<ObjectType> {
    @Override
    public void write(final JsonWriter jsonWriter, final ObjectType enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public ObjectType read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return ObjectType.fromValue(String.valueOf(value));
    }
  }
}

