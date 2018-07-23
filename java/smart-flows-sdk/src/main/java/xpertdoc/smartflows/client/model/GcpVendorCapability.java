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
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * GcpVendorCapability
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class GcpVendorCapability {
  /**
   * Gets or Sets type
   */
  @JsonAdapter(TypeEnum.Adapter.class)
  public enum TypeEnum {
    RANGE("range"),
    
    SELECT("select"),
    
    TYPEDVALUE("typedValue");

    private String value;

    TypeEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static TypeEnum fromValue(String text) {
      for (TypeEnum b : TypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<TypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final TypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public TypeEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return TypeEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("type")
  private TypeEnum type = null;

  @SerializedName("id")
  private String id = null;

  @SerializedName("displayName")
  private String displayName = null;

  @SerializedName("range")
  private GcpVendorCapabilityRange range = null;

  @SerializedName("select")
  private List<GcpVendorCapabilitySelect> select = null;

  @SerializedName("typedValue")
  private GcpVendorCapabilityTypedValue typedValue = null;

  public GcpVendorCapability type(TypeEnum type) {
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @ApiModelProperty(value = "")
  public TypeEnum getType() {
    return type;
  }

  public void setType(TypeEnum type) {
    this.type = type;
  }

  public GcpVendorCapability id(String id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public GcpVendorCapability displayName(String displayName) {
    this.displayName = displayName;
    return this;
  }

   /**
   * Get displayName
   * @return displayName
  **/
  @ApiModelProperty(value = "")
  public String getDisplayName() {
    return displayName;
  }

  public void setDisplayName(String displayName) {
    this.displayName = displayName;
  }

  public GcpVendorCapability range(GcpVendorCapabilityRange range) {
    this.range = range;
    return this;
  }

   /**
   * Get range
   * @return range
  **/
  @ApiModelProperty(value = "")
  public GcpVendorCapabilityRange getRange() {
    return range;
  }

  public void setRange(GcpVendorCapabilityRange range) {
    this.range = range;
  }

  public GcpVendorCapability select(List<GcpVendorCapabilitySelect> select) {
    this.select = select;
    return this;
  }

  public GcpVendorCapability addSelectItem(GcpVendorCapabilitySelect selectItem) {
    if (this.select == null) {
      this.select = new ArrayList<GcpVendorCapabilitySelect>();
    }
    this.select.add(selectItem);
    return this;
  }

   /**
   * Get select
   * @return select
  **/
  @ApiModelProperty(value = "")
  public List<GcpVendorCapabilitySelect> getSelect() {
    return select;
  }

  public void setSelect(List<GcpVendorCapabilitySelect> select) {
    this.select = select;
  }

  public GcpVendorCapability typedValue(GcpVendorCapabilityTypedValue typedValue) {
    this.typedValue = typedValue;
    return this;
  }

   /**
   * Get typedValue
   * @return typedValue
  **/
  @ApiModelProperty(value = "")
  public GcpVendorCapabilityTypedValue getTypedValue() {
    return typedValue;
  }

  public void setTypedValue(GcpVendorCapabilityTypedValue typedValue) {
    this.typedValue = typedValue;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GcpVendorCapability gcpVendorCapability = (GcpVendorCapability) o;
    return Objects.equals(this.type, gcpVendorCapability.type) &&
        Objects.equals(this.id, gcpVendorCapability.id) &&
        Objects.equals(this.displayName, gcpVendorCapability.displayName) &&
        Objects.equals(this.range, gcpVendorCapability.range) &&
        Objects.equals(this.select, gcpVendorCapability.select) &&
        Objects.equals(this.typedValue, gcpVendorCapability.typedValue);
  }

  @Override
  public int hashCode() {
    return Objects.hash(type, id, displayName, range, select, typedValue);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GcpVendorCapability {\n");
    
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    displayName: ").append(toIndentedString(displayName)).append("\n");
    sb.append("    range: ").append(toIndentedString(range)).append("\n");
    sb.append("    select: ").append(toIndentedString(select)).append("\n");
    sb.append("    typedValue: ").append(toIndentedString(typedValue)).append("\n");
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

