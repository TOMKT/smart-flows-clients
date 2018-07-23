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
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModelProperty;

import java.io.IOException;
import java.util.Objects;

/**
 * SystemInfoDefaults
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class SystemInfoDefaults {
  /**
   * Gets or Sets esignProvider
   */
  @JsonAdapter(EsignProviderEnum.Adapter.class)
  public enum EsignProviderEnum {
    DOCUSIGN("DocuSign"),
    
    SERTIFI("Sertifi");

    private String value;

    EsignProviderEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static EsignProviderEnum fromValue(String text) {
      for (EsignProviderEnum b : EsignProviderEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<EsignProviderEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final EsignProviderEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public EsignProviderEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return EsignProviderEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("esignProvider")
  private EsignProviderEnum esignProvider = null;

  public SystemInfoDefaults esignProvider(EsignProviderEnum esignProvider) {
    this.esignProvider = esignProvider;
    return this;
  }

   /**
   * Get esignProvider
   * @return esignProvider
  **/
  @ApiModelProperty(value = "")
  public EsignProviderEnum getEsignProvider() {
    return esignProvider;
  }

  public void setEsignProvider(EsignProviderEnum esignProvider) {
    this.esignProvider = esignProvider;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SystemInfoDefaults systemInfoDefaults = (SystemInfoDefaults) o;
    return Objects.equals(this.esignProvider, systemInfoDefaults.esignProvider);
  }

  @Override
  public int hashCode() {
    return Objects.hash(esignProvider);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SystemInfoDefaults {\n");
    
    sb.append("    esignProvider: ").append(toIndentedString(esignProvider)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
